WCF-at-your-service
===================

This is just an introduction to WCF, i hope this help more than 1 (me).


##Concepts
  A must to mention concept: "Connected Systems", is a short name for applications distributed across
multiple computer nodes who can comunicate with each other node through network (A.K.A. Distribuetd applications)

##Previous things:
####MS DCOM/COM/ES
	Component-oriented(RPC)
	Distributed transactions
	Dcom infraestructure
	
####.NET Remoting
	Component-oriented(RPC)
	simple&high extensible
	CLR infraestructure
	
####MSMQ
	Message-Oriented
	Asynchronous-durable-reliable
	MSMQ infrastructure	

#####But they are old and requiere a unique programming model each, available only in windows, 
then to provide a connected system what it requires, a Service would have to promote interoperability exposing 
unist of functionality and all of this via messaging using a standar protocol and a message format.

##concepts about Service design philosophies:
####SOAP XML messaging 
	Using SOAP as the format enhanced with the WS-* protocols, can be used with any transport 
	protocol (heavy, typical in the enterprise, RPC-based too)
####REST Design paradigm 
	Focused on how to identify, represent, and operate on resources through a unified interface (http) 
	(typical in public-facing web scenarios) embrace HTTP services modeled as resources with unique URL
	http define uniform service contract:get, post, put, delete, head; Resources can be represented as xml, rss, json, etc.

##Another not so old but still previous thing:
####ASP.NET Web Services(ASMX)
	Basic XML over HTTP Simple support for SOAP 1.1/1.2
	Web Services Enhancements (WSE)
	Added support for WS-Security et al and TCP services.
#####But again unique programming model.

#### Finally 	an ideal Communication Framework should include
	unified programming model.
	Design options: SOAP, REST, dist. objects...
	Transport protocol:HTTP, TCP, MSMQ...
	Message formats:XML, MTOM, JSON, binary...
	Message Protocols: WS-*, none...
	Additional flexibility via extensibility.

### And aparently is with this in mind that WCF was conceived
