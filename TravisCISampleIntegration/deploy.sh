ApiKey=$1
Source=$2

nuget pack ./TravisCISampleIntegration/SumUtils/SumUtils.nuspec -Verbosity detailed

nuget push SumUtils.*.nupkg -Verbosity detailed -ApiKey $ApiKey -Source $Source