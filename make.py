#!/usr/bin/python3

import sys
import os
import subprocess
import time

projects = ["01-HelloWorld"]
dotnetVariants = ["dotnet", "dotnet.exe"]
dotnet   = ""

# -------------------------------------------------------------------------------------------------------------------
#                                               HELPER

# https://www.tutorialspoint.com/How-to-remove-a-directory-recursively-using-Python
def removeDirectory(path):
    if os.path.exists(path):
        for root, dirs, files in os.walk(path, topdown=False):
            for name in files:
                file_path = os.path.join(root, name)
                print("About do delete:", file_path)
                os.remove(file_path)
            for name in dirs:
                dir_path = os.path.join(root, name)
                print("About do delete:", dir_path)
                os.rmdir(dir_path)
        print("About do delete:", path)
        os.rmdir(path)

def runCommand(command, silent=False):
    print("Execute:", command)  
    try:
        if silent == False:
            outDevice = None
        else:
            outDevice = subprocess.DEVNULL

        result = subprocess.run(command, stdout=outDevice)
        if result.returncode != 0:
            print("---> Command failed with returncode:", result.returncode)
            return False
        return True
    except:
          print("---> FATAL: can't execute command")
    return False

def buildProject(folder, command):
    print("Now entering:",folder)
    os.chdir(folder)
    runCommand(command)
    os.chdir("../")

def buildAll(command):
    global projects
    print("Build all projects")
    for project in projects:
        buildProject(project,command)

#--------------------------------------------------------------------------------------------------------------------
#                                                   TARGETs
def targetBuild():
    buildAll([dotnet, "run"])

def targetClean():
    global projects
    print("Cleanup projects")
    for project in projects:
        print("Now entering:",project)
        os.chdir(project)
        runCommand([dotnet, "clean"])
        time.sleep(0.3) # I don't know why I can't delete folders without sleep. Seems that the runCommand-process stills own the subfolder..
        removeDirectory("bin")
        removeDirectory("obj")
        os.chdir("../")

def targetHelp():
    for target in functions:
        print("Target: ", target)

def targetConfig():
    global dotnet
    print("Configure")
    for dotnetVariant in dotnetVariants:
        print("Test variant: ", dotnetVariant)
        result = runCommand([dotnetVariant,"--info"], silent=True)
        if result == True:
            print("OK")
            dotnet = dotnetVariant
    print(".NET is:", dotnet)

def runTarget(targetName):
    global functions
    if targetName in functions:
        print("Execute target: ", targetName)
        if type(functions[targetName]) == list:
            for subTarget in functions[targetName]: 
                runTarget(subTarget)
        else:
            functions[targetName]()
    else:
        print("FATAL: INVALID TARGET:", targetName)

#--------------------------------------------------------------------------------------------------------------------
#                                                    MAIN
functions  = {'build': targetBuild, 'clean': targetClean, 'help': targetHelp, 'configure': targetConfig, 'all': ['build']}
targetName = 'help'

if len(sys.argv) > 1:
    targetName = sys.argv[1]

runTarget("configure")
runTarget(targetName)

print("make.py ended")

