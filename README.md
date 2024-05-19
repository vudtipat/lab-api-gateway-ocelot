This Project I want to apply Clean architecure and DDD to my project web api about e-commerce

- Clean Architecture project referance
    Domian => Application => Infrastructure => Api

- Ocelot APiGw
    I use MMLib.Ocelot.Provider.AppConfiguration for easier to maintainance when i want to add new service or edit host or port (https://github.com/Burgyn/MMLib.Ocelot.Provider.AppConfiguration)
    I use MMLib.SwaggerForOcelot for generate swagger of api gateway(https://github.com/Burgyn/MMLib.SwaggerForOcelot)

- System Architecture
    +-+-+-+-+-+-+-+          +-+-+-+-+-+-+-+        +-+-+-+-+-+-+-+      
    |             |          |             |        |             |
    |   Client    |     =>   |    ApiGw    |   =>   |    Micro    |  
    |             |          |             |        |             |
    +-+-+-+-+-+-+-+          +-+-+-+-+-+-+-+        +-+-+-+-+-+-+-+
