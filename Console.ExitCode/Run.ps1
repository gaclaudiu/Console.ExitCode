$testProcess = Start-Process   -FilePath 'Console.ExitCode.exe ' -ArgumentList '0',"`"[{IP:'localhost', MaxJobsToRun: 2}]`"", 'C=A'  -PassThru 
Wait-Process -Id $testProcess.Id -Timeout 120
if ( $testProcess.ExitCode -eq 0){
	Write-Output "Success"
} 
if ($testProcess.ExitCode -eq 1){
Write-Error "Failure"
}