USER_ID=`id -u`
USER_GROUP=`id -g`
DOCKER_USER_RUN="$(USER_ID):$(USER_GROUP)"

OPENAPI_PATH=${PWD}/../ev.openapiv3.yaml

define generate
	mkdir -p $(1)
	docker run --user "$(DOCKER_USER_RUN)" --rm -v ${PWD}/$(1):/local/out -v $(OPENAPI_PATH):/local/openapi.yaml swaggerapi/swagger-codegen-cli-v3 generate \
	-i /local/openapi.yaml \
	-l $(1) \
	-o /local/out/
endef

update: gen cp.openapi.file

gen: gen.go gen.php gen.python gen.java gen.javascript gen.csharp

gen.php:
	$(call generate,php)

gen.go:
	$(call generate,go)

gen.python:
	$(call generate,python)

gen.java:
	$(call generate,java)

gen.javascript:
	$(call generate,javascript)

gen.csharp:
	$(call generate,csharp)

cp.openapi.file:
	cp $(OPENAPI_PATH) ./