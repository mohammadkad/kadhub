<!-- 1404-10-08 -->

- Enable the Windows Subsystem for Linux
- dism.exe /online /enable-feature /featurename:Microsoft-Windows-Subsystem-Linux /all /norestart
- Enable Virtual Machine feature
- dism.exe /online /enable-feature /featurename:VirtualMachinePlatform /all /norestart
- wsl.exe --install or wsl.exe --update

