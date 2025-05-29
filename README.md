# API.NET.AWS.ECS
Cloud-native .NET API deployed on AWS using ECS with Fargate. Containerized, scalable, and serverless architecture

# Summary
- [Application](#application)
- [Amazon ECR](#amazon-ecr)
- [References](#references)



## Application

### Create Docker Image
After creating the application, let’s create the dockerfile and and run the command at the root of the project

```
docker build -t book-manager .
```

![image](https://github.com/user-attachments/assets/b3a30418-9006-40d0-8f9f-7682b90c435a)


## Amazon ECR

![image](https://github.com/user-attachments/assets/0a764a2d-8e5c-4839-93d6-4ae536db2c11)


### Create Repository

![image](https://github.com/user-attachments/assets/08c862a3-6bef-4148-899f-601715e13f80)



# References
https://codewithmukesh.com/blog/deploy-aspnet-core-web-api-to-amazon-ecs/

https://www.cloudzero.com/blog/ecs-vs-eks/
