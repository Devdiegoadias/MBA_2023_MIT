<!-- PROJECT SHIELDS -->
<!--
*** I'm using markdown "reference style" links for readability.
*** Reference links are enclosed in brackets [ ] instead of parentheses ( ).
*** See the bottom of this document for the declaration of the reference variables
*** for contributors-url, forks-url, etc. This is an optional, concise syntax you may use.
*** https://www.markdownguide.org/basic-syntax/#reference-style-links
-->
[![Contributors][contributors-shield]][contributors-url]
[![Watchers][watchers-shield]][watchers-url]
[![Stargazers][stars-shield]][stars-url]
[![Forks][forks-shield]][forks-url]
[![Issues][issues-shield]][issues-url]
[![MIT License][license-shield]][license-url]

---

# RabbitMQ and .Net Core
A simple example project using RabbitMQ and .Net Core 6 (console).


## What is RabbitMQ?

RabbitMQ is an open source message broker software. It accepts messages from producers, and delivers them to consumers. It acts like a middleman which can be used to reduce loads and delivery times taken by web application servers.

I recommend you visit the project [website](https://www.rabbitmq.com/) and even the [tutorials page](https://www.rabbitmq.com/getstarted.html).


## The project

This project consists of three sub-projects, which are:
- **RabbitMQNetCore**: a class project containing a class to type our message and also classes with the rules for sending and consuming the message.
- **RabbitMQNetCore.Publisher**: a console project responsible for running the publisher.
- **RabbitMQNetCore.Consumer**: a console project responsible for running the consumer.

Could I have created a single project, yes I could, but I wanted to separate it for a better understanding of what each one does.


## How to run?

First we need to run the RabbitMQ service, I recommend that you make use of a Docker image, so you need to have Docker installed and run the following command:

```bash
docker run -d --hostname localhost --name localrabbit -e RABBITMQ_DEFAULT_USER=user -e RABBITMQ_DEFAULT_PASS=password rabbitmq:3-management
```

This command will create and run an instance of RabbitMQ.

Run the Publisher project:

```bash
dotnet run --project .\RabbitMQNetCore.Publisher\RabbitMQNetCore.Publisher.csproj
```

Run the Consumer project:

```bash
dotnet run --project .\RabbitMQNetCore.Consumer\RabbitMQNetCore.Consumer.csproj
```

Now, in the Publisher console, you can perform tests by sending messages and monitoring the consumption of the same in the Consumer console.

This is a simple project to demonstrate how the messaging service works.


## License

This project is [MIT Licensed](https://github.com/anzolin/RabbitMQNetCore/blob/master/LICENSE).

  
## About the author

Hello everyone, my name is Diego Anzolin Ferreira. I'm a .NET developer from Brazil. I hope you will enjoy this project as much as I enjoy developing it. If you have any problems, you can post a [GitHub issue](https://github.com/anzolin/AnzolinNetDevPack/issues). You can reach me out at diego@anzolin.com.br.


## Donate
  
Want to help me keep creating open source projects, make a donation:

[![Donate](https://img.shields.io/badge/Donate-PayPal-green.svg?style=for-the-badge)](https://www.paypal.com/donate?business=DN2VPNW42RTXY&no_recurring=0&currency_code=BRL) [![Donate](https://img.shields.io/badge/-buy_me_a%C2%A0coffee-gray?logo=buy-me-a-coffee&style=for-the-badge)](https://www.buymeacoffee.com/anzolin)

Thank you!



<!-- MARKDOWN LINKS & IMAGES -->
<!-- https://www.markdownguide.org/basic-syntax/#reference-style-links -->
[contributors-shield]: https://img.shields.io/github/contributors/anzolin/RabbitMQNetCore.svg?style=for-the-badge
[contributors-url]: https://github.com/anzolin/RabbitMQNetCore/graphs/contributors
[forks-shield]: https://img.shields.io/github/forks/anzolin/RabbitMQNetCore.svg?style=for-the-badge
[forks-url]: https://github.com/anzolin/RabbitMQNetCore/network/members
[watchers-shield]: https://img.shields.io/github/watchers/anzolin/RabbitMQNetCore.svg?style=for-the-badge
[watchers-url]: https://github.com/anzolin/RabbitMQNetCore/watchers
[stars-shield]: https://img.shields.io/github/stars/anzolin/RabbitMQNetCore.svg?style=for-the-badge
[stars-url]: https://github.com/anzolin/RabbitMQNetCore/stargazers
[issues-shield]: https://img.shields.io/github/issues/anzolin/RabbitMQNetCore.svg?style=for-the-badge
[issues-url]: https://github.com/anzolin/RabbitMQNetCore/issues
[license-shield]: https://img.shields.io/github/license/anzolin/RabbitMQNetCore.svg?style=for-the-badge
[license-url]: https://github.com/anzolin/RabbitMQNetCore/blob/master/LICENSE.txt
