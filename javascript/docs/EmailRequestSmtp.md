# EmailValidator.EmailRequestSmtp

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**emailFrom** | **String** |  | [optional] 
**helloName** | **String** |  | [optional] [default to &#x27;localhost&#x27;]
**proxy** | **String** | Versions - SOCKS4, SOCKS4A and SOCKS5. Format -  schema://username:password@host:port.  | [optional] 
**timeoutConnection** | **Number** | timeout creating smtp connection | [optional] [default to 5.0]
**timeoutResponse** | **Number** | timeout of communication with smtp server | [optional] 
**port** | **Number** | smtp port remote server | [optional] [default to 25]
