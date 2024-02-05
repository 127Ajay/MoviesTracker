# Asp.Net Core Web API

### REST

- Represntation state transfer
- Architectural style used to build distrubuted hypermedia system.

### 6 constraints of REST
1. Uniform interface
    - Identification of the resource
    - Maniplutaion of the resiurce through represntation
    - Self descriptive Message
    - Hypermedia as the engine of application state

2. Stateless (**Important**)
   - Client sends all the information that is needed to process that request
   - Does not depend on previous request
3. Cacheable
4. Client-Server
5. Layered System
6. Code on Demand (optional)


### Resource Naming and Routing 
- Resource are the item that we store
- /movies -> To Access all movies
          -> Must be Pural
- /movies/1 -> to find particular movie
            -> using id
- /movies/1/ratings

### Http verb
Idempotency : No matter how many time we process a specific request the result will always be the same on the server

1. Safe
   - Get -> Retrive -> Idempotent 
2. Unsafe
   - Post -> Create -> NOT Idempotent 
   - Put -> Complete update -> Idempotent 
   - Patch -> Partial update -> Idempotent 
   - Delete -> Delete -> Idempotent 

Head -> Idempotent 
Option -> Idempotent 
Trace -> Idempotent 

### HTTP status code
1. **100**: **100 means Continue**. The HTTP 100 Continue informational status response code indicates that everything so far is OK and that the client should continue with the request or ignore it if it is already finished.
2. **200**: **200 means OK**. The HTTP 200 OK success status response code indicates that the request has succeeded. If you are searching for some data and you got the data properly. That means the request is successful and, in that case, you will get 200 OK as the HTTP status code.
3. **201**: **201 means a new resource created**. The HTTP 201 Created success status response code indicates that the request has succeeded and has led to the creation of a resource. The new resource is effectively created before this response is sent back and the new resource is returned in the body of the message, its location being either the URL of the request or the content of the Location header. If you are adding successfully a new resource by using the HTTP Post method, then in that case you will get 201 as the Status code.
4. **204**: **204 means No Content**. The HTTP 204 No Content success status response code indicates that a request has succeeded, but that the client doesn’t need to navigate away from its current page. If the server processed the request successfully and it is not returning any content, then in that case you will get a 204-response status code.
5. **301**: **301 means Moved Permanently**. If you are getting 301 as a status code from the server, it means the resource you are looking for is moved permanently to the URL given by the Location headers.
6. **302**: **302 means Found**. If you are getting 302 as a status code from the server, it means the resource you are looking for is moved temporarily to the URL given by the Location headers.
7. **400**: **400 means Bad Request**. If you are getting 400 as the status code from the server, then the issue is with the client request. If the request contains some wrong data such as malformed request syntax, invalid request message framing, or deceptive request routing, then we will get this 400 Bad Request status code.
8. **401**: **401 means Unauthorized**. If you are trying to access the resource for which you don’t have access (Invalid authentication credentials), then you will get a 401 unauthorized status code from the server.
9. **404**: **404 means Not Found**. If you are looking for a resource that does not exist, then you will get this 404 Not Found status code from the server. Links that lead to a 404 page are often called broken or dead links.
10. **405**: **405 means Method Not Allowed**. The 405 Method Not Allowed response status code indicates that the request method is known by the server but is not supported by the target resource. For example, we have one method which is a POST method in the server and we trying to access that method from the client using GET Verb, then, in that case, you will get a 405-status code.
11. **500**: **500 means Internal Server Error**. If there is some error in the server, then you will get a 500 Internal Server Error status code.
12. **501**: **501 Not Implemented server error response code means that the server does not support the functionality required to fulfill the request**. This status can also send a Retry-After header, telling the requester when to check back to see if the functionality is supported by then.
13. **503**: **503 means Service Unavailable**. The 503 Service Unavailable server error response code indicates that the server is not ready to handle the request. If the server is down for maintenance or the server is overloaded then in that case, you will get the 503 Service Unavailable Status code.
14. **504**: **504 means Gateway Timeout**. The 504 Gateway Timeout server error response code indicates that the server while acting as a gateway or proxy, did not get a response in time from the upstream server that is needed in order to complete the request.

A. **POST**:
    - Single Resource : N/A
    - Collection Resource: 201(Location Header), 202 (Accepted)


B. **GET**:
    - Single Resource: 200 (ok), 404 (Not found)
    - Collection Resource: 200 (OK)


C. **PUT**:
    - Single Resource: 200 (ok), 204 (No Content), 404 (Not found)
    - Collection Resource: 405 (Method not allowed)


D. **Delete**:
    - Single Resource :  200 (ok), 404 (Not found)
    - Collection Resource: 405 (Method not allowed)


### Response body options
    -> JSON : Most of the time

### HATEOS (Hypermedia as the engine of application state)
{
    "account": {
        "account_number": 12345,
        "balance": {
            "currency": "usd",
            "value": 100.00
        },
        "links": {
            "deposits": "/accounts/12345/deposits",
            "withdrawals": "/accounts/12345/withdrawals",
            "transfers": "/accounts/12345/transfers",
            "close-requests": "/accounts/12345/close-requests"
        }
    }
}

### Types of errors

| Error | Fault |
| Client sends invalid data | Someting wrong with the server |
| 400 error | 500 error |
