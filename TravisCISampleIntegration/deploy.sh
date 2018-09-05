ApiKey=$1
Source=$2

nuget pack ./SumUtils/SumUtils.nuspec -Verbosity detailed

nuget push ./SumUtils/SumUtils.*.nupkg -Verbosity detailed -ApiKey $ApiKey -Source $Source