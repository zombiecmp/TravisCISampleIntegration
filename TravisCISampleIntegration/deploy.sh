ApiKey=$1
Source=$2

nuget pack ./TravisCISampleIntegration/SumUtils/SumUtils.nuspec -Verbosity detailed

nuget push ./TravisCISampleIntegration/SumUtils.*.nupkg -Verbosity detailed -ApiKey $ApiKey -Source $Source