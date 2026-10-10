```
curl -s https://api.liquid.ai/decisions/v1/systemone \
  -H "Authorization: Bearer $LIQUID_API_KEY" \
  -H "Content-Type: application/json" \
  -d '{
    "model": "d1:free",
    "state": "I have been waiting over three weeks for my order and nobody has responded to my emails. This is completely unacceptable.",
    "questions": {
      "is_complaint": {
        "type": "noul",
        "instructions": "Is this message a complaint from the customer?"
      }
    }
  }'
```


```
curl -X GET "https://.../api/v1/NAME?CODE=1234" -H "accept: application/json" -H "authorization: Bearer YOUR_JWT" --compressed -o response.txt
```
