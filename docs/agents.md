
## Get all the Agents

## Get a Single Agent

### Request

```
GET /agents
Accept: application/json
```

### Response

```
200 Ok
Content-Type: application/json

```

```json
{
    "agents": [
        { 
            "id": 939, 
            "firstName": "Bob", 
            "lastName": "Smith", 
            "phone": "555-1212", 
            "email": "Bob@aol.com"
        }
    ]
}

```

## Adding An Agent

### Request

When you are posting to a collection, the "meaning" of post is:

> please consider making this a new document (subordinate resource)
``` 
POST /agents
Content-Type: application/json
Accept: application/json
```

```json
{
    "firstName": "Bob", 
    "lastName": "Smith", 
    "phone": "555-1212", 
    "email": "Bob@aol.com"
}

```

### Reponse

**Happy Path**
```
201 Created
Location: http://localhost:1337/agents/32
Content-Type: application/json
```

```json
{
    "id": 32,
    "firstName": "Bob", 
    "lastName": "Smith", 
    "phone": "555-1212", 
    "email": "Bob@aol.com"
}

```

**Sad Path**

```
400 Bad Request
```



