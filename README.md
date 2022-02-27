# try-aks-rms

https://docs.microsoft.com/en-us/azure/aks/tutorial-kubernetes-deploy-cluster?tabs=azure-cli


https://docs.microsoft.com/en-us/azure/devops/pipelines/ecosystems/kubernetes/aks-template?view=azure-devops

https://www.azuredevopslabs.com/labs/vstsextend/kubernetes/

https://docs.microsoft.com/en-us/learn/modules/deploy-kubernetes/5-clean-up-environment
https://docs.microsoft.com/en-us/learn/modules/deploy-docker/4-deploy-docker

docker image tag rhel-httpd:latest registry-host:5000/myadmin/rhel-httpd:latest
 docker image push registry-host:5000/myadmin/rhel-httpd:latest

Create azure deops project
create initial build pipeline for web project Rms.Web Pipeline
Modify Rms.Web pipeline for build an push to docker registry
Create docker hub service connection
Modify Rms.Web pipeline for support release to azure web app service

create dev branch
Modify Rms.Web pipeline for use template (need when other two projects going to build)
Create RMS.Gateway pipeline to push image to docker

Research - deployment to AKS.
    dynamic image name
    environment variables updates

