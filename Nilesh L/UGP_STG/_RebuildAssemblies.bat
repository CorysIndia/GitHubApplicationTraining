echo off
@setlocal enableextensions
@cd /d "%~dp0"

echo ------------------------------------------------------------------------
echo Generating UGP_STG
echo ------------------------------------------------------------------------
"C:\Program Files (x86)\MSBuild\14.0\Bin\MSBuild.exe" /verbosity:m "UGP_STG.sln" /p:Configuration=Release /p:Platform="Any CPU" /m /t:Clean;Rebuild
if errorlevel 1 goto :error_compile

goto :end	

:error_compile
echo "Rebuild failed"
pause
goto :end

:error_setup
echo "Error generating setup"
pause

:end


