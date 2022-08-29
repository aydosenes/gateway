## Info

This is an API Gateway for Contact Management and Reporting System. This repository must be used with related repositories as microservices.

Contact Service: https://github.com/aydosenes/contact-service

Report Service: https://github.com/aydosenes/report-service

## Prerequisites

.NET Core 3.1, DockerHub, MassTransit(RabbitMQ), MongoDB, Ocelot API Gateway, CQRS(Mediatr) Pattern, XUnit Test

## Steps

1- Make sure you have .NET Core 3.1 SDK and Visual Studio 2019

2- DockerHub Desktop for containerizations of RabbitMQ and MongoDB

![image](https://user-images.githubusercontent.com/34930943/187288305-0e12c6e2-1f26-4635-b29e-71eae6c1a395.png)

3- MongoDBCompass for Database Management

4- Postman

Once you have cloned these 3 repositories, run them all and use http://localhost:5000 port for the gateway.

You can see the endpoints in ocelot.json in gateway.

Add some contact with their details by http://localhost:5000/contact-service/contact/add-contact-with-detail endpoint

Example JSON: http://jsonblob.com/1013899082766499840

And to see the report results in excel file, copy and paste this url to browser then hit enter!

http://localhost:5000/report-service/report/get-report

## License
[MIT](https://choosealicense.com/licenses/mit/)
