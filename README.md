SoaDemo
=======

The purpose of this application is to demonstrate how to architect an SOA 
application in an ASP.NET WCF application.  It uses principles outlined by 
Martin Fowler in his book Patterns of Enterprise Application Architecture.
	Data Transfer Objects
	Remote Facade
	Repository
	Dependency Injection

This is a basic project, the purpose of which is to provide an easy to work with
pattern for building your application. It does not address various binding 
scenarios.  It's meant to answer the questions of "where do I put this and that 
and what should my dependencies be".


Notes
-----

Build the database project first, then publish.

Be sure to visit the .config files and set their connection strings appropriately.
	SoaDemo.Data - App.config
	SoaDemo.Services - Web.config

Please refer to the \Docs\SOA_Architecture.vsdx visio file for an overview of the application architecture.

