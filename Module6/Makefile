cluster-delete:
	kind delete cluster --name k8s-course

cluster-create:
	kind create cluster --name k8s-course --config Kind/KindCluster.yaml

build-hello-api:
	docker build -t hello-api:local ./Hello.Api; kind load docker-image hello-api:local --name k8s-course

build-name-api:
	docker build -t name-api:local ./Name.Api; kind load docker-image name-api:local --name k8s-course

delete-namespace:
	kubectl delete namespace services-demo

apply-namespace:
	kubectl apply -f k8s/Namespace.yaml 

apply-hello-api:
	kubectl apply -f k8s/HelloApi.yaml
	
apply-name-api:
	kubectl apply -f k8s/NameApi.yaml

re-apply-all:
	make delete-namespace; make apply-namespace; make apply-hello-api; make apply-name-api

restore-all:
	make cluster-delete; make cluster-create; make apply-namespace; make apply-hello-api; make apply-name-api