@echo off 
start cmd /k "cd /d %cd% & git add * & git commit -m 'x' & git push & exit"
