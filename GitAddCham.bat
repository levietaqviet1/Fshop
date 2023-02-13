@echo off
set /p commit_message=Enter commit message: 
start cmd /k "cd /d %cd%  & git add . & git commit -m '%commit_message%' & git push & exit"
