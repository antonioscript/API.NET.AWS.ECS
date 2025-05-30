# API.NET.AWS.ECS
API developed in .NET, containerized with Docker, and deployed to AWS using ECS Fargate. The cluster includes two main services: the API itself and a MongoDB database.

# Summary
- [Application](#application)
  - [Create Docker Image](#create-docker-image)
  - [Execute Container](#execute-container)
- [Amazon ECR](#amazon-ecr)
  - [Create Repository](#create-repository)
  - [Pushing Docker Image to Amazon ECR](#pushing-docker-image-to-amazon-ecr)
- [Deploy ASP.NET Core Web API to Amazon ECS](#deploy-aspnet-core-web-api-to-amazon-ecs)
  - [Create Tasks](#create-tasks)
  - [Create Service Mongo](#create-service-mongo)
  - [Create Task .NET API](#create-task-net-api)
  - [Create Service .NET API](#create-service-net-api)
- [Test](#test)
- [References](#references)




## Application

### Create Docker Image
After creating the application, let’s create the dockerfile and and run the command at the root of the project

```
docker build -t book-manager .
```

![image](https://github.com/user-attachments/assets/b3a30418-9006-40d0-8f9f-7682b90c435a)

### Execute Container
```
docker run -p 8080:8080 -e MONGODBCONFIG:CONNECTIONSTRING='mongodb://host.docker.internal:27017' -e ASPNETCORE_ENVIRONMENT=Development book-manager
```
</br>

![image](https://github.com/user-attachments/assets/0c65f354-efb3-407f-aed4-28372db0f0d2)


## Amazon ECR

![image](https://github.com/user-attachments/assets/0a764a2d-8e5c-4839-93d6-4ae536db2c11)



### Create Repository

![image](https://github.com/user-attachments/assets/08c862a3-6bef-4148-899f-601715e13f80)

![image](https://github.com/user-attachments/assets/da7e1a76-8836-4646-8fce-e91460a8cab7)

### Pushing Docker Image to Amazon ECR

Open up the Terminal at the location where the DockerFile exists and run the following command. Probably run it line by line.</br>
</br> **PS: Make sure that you replace the 637423290521 with your AWS account id**


```
aws ecr get-login-password | docker login --username AWS --password-stdin 637423290521.dkr.ecr.us-east-1.amazonaws.com
```


```
docker tag book-manager 637423290521.dkr.ecr.us-east-1.amazonaws.com/ecs/book-manager
```

```
docker push 637423290521.dkr.ecr.us-east-1.amazonaws.com/ecs/book-manager
```

You can verify this by going into ECR and confirming that a new image has come in.

![image](https://github.com/user-attachments/assets/edf2b424-1b8e-4578-8acc-e49544861389)

## Deploy ASP.NET Core Web API to Amazon ECS

![image](https://github.com/user-attachments/assets/52b2c329-9da3-4a08-8daf-4282cc5b2c8e)

![image](https://github.com/user-attachments/assets/373c79dc-43b9-4612-973e-4d962d76ad87)

![image](https://github.com/user-attachments/assets/a8dcff17-c784-45b4-8519-bf405f6594ed)


### Create Tasks
- Mongo DB Task
- Book Manager Task

Go to AWS ECS, and on the sidebar, click on Task Definitions. Here, Create a new Task Definition.

![image](https://github.com/user-attachments/assets/c337f25e-e0ff-4961-8752-62ccb3f8c4a9)

![image](https://github.com/user-attachments/assets/9325daec-d29d-40d0-a17d-904df79342de)

![image](https://github.com/user-attachments/assets/23df045e-415d-498b-adb5-6f3c2bdcff3f)

![image](https://github.com/user-attachments/assets/3ffe0c31-684a-459d-b7c6-1410b6e5274b)

### Create Service Mongo 

![image](https://github.com/user-attachments/assets/a1bf71f0-2859-426b-abe9-79ea5941cf5f)

![image](https://github.com/user-attachments/assets/e634bcf6-ba1d-4164-98f6-5c2ef9f63a62)

### Create Task .NET API 

![image](https://github.com/user-attachments/assets/6d953bda-33c1-4ca1-b058-1c8c11f76627)

![image](https://github.com/user-attachments/assets/22e3905d-ccaa-46b9-b855-2d813bbe7d61)
_PS: The Secret for connection with the mango work is in the environment variables!_
_PS: If port 80 does not work, put 8080 and remember to release the entry in the security group_

</br>

![image](https://github.com/user-attachments/assets/5d0074c5-108d-4eb0-b9ee-8cab23e57c48)

### Create Service .NET API 

![image](https://github.com/user-attachments/assets/4b8537e1-4d26-4628-b567-5828276b3bd5)


## Test

_URL: http://44.197.101.227:8080/swagger_

</br>

Go to Public IP of Service API and paste in browser
</br>

![image](https://github.com/user-attachments/assets/ddde160b-1939-41d1-aac6-f10eb376cce0)




## References
https://codewithmukesh.com/blog/deploy-aspnet-core-web-api-to-amazon-ecs/

https://www.cloudzero.com/blog/ecs-vs-eks/
