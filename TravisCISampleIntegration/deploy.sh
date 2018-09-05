ApiKey=$1
Source=$2

nuget pack ./TravisCISampleIntegration/SumUtils/SumUtils.nuspec -Verbosity detailed

nuget push ./TravisCISampleIntegration/SumUtils/SumUtils.1.0.nupkg -Verbosity detailed -ApiKey $ApiKey -Source $Source