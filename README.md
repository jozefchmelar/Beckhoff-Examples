# Beckhoff-Examples
## Modern features in not so modern environment.

This repository contains simple features like : 

- Sending a text message 
- Sedning an email
- Sorting an array
- Making a REST API call
- Data persistance to a database
- Generated user interface

**BUT** with a PLC. PLC is an idustrial Arduino on steroids.

Unfortunatelly working with PLC is cumbersome. 

PLCs were meant to replace physical wiring of relay logic - so it's more electrical engineering than software engineering.

So obviously it's not really good at software stuff.

...unfortunatelly the industry forces you to write enterprise software in a PLC.

Beckhoff's TwinCAT 3 is one of few which offers modern features like object oriented programming, open API and integration in Visual Studio. 
Other platforms are using their own IDE with their own language.

Inxton is another tool I'm using. It creates C# classes from PLC's function blocks a structs. You need a free license you can get [here](https://inxton.com/getting-started)

I'm invoking C# methods from PLC and transfering data from PLC to a database with ORM. 

If you're a software developer and you're wondering - what? that basic stuff!

Yes it is basic, but not in the world of PLC's. 
