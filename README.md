# Azure devops pipeline for Azure Kubernetes Service

## what is included in pipeline Rms-web-aks-pipeline.yml
1. Buld and push to docker repo
2. use of File transformer to modify appsettings.json to reflect values in Staging environment
3. Create namespace in AKS
4. Create config map using Transformerd appsettings.json
5. Create config map from to literal to set environment variales ASPNET_CORE_ENVIRONMENT
6. Deloy to AKS


