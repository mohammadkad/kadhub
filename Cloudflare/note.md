###  C3 (create-cloudflare-cli)
### https://developers.cloudflare.com/workers/get-started/guide/
- npm create cloudflare@latest -- my-first-worker
- cd my-first-worker
- npx wrangler dev
- npx wrangler deploy
- <YOUR_WORKER>.<YOUR_SUBDOMAIN>.workers.dev

<!-- 1405-06-15 -->
- npm i wrangler
- npx wrangler --version
- npx wrangler whoami
- npx wrangler init my-worker -y # Hello World worker
- cd my-worker
- npm run dev
- npm run deploy # publish your worker
  - OR : npx wrangler deploy # Publish online <!-- URL > https://my-worker.mkq-saba.workers.dev -->
 
### Database, D1:
- npx wrangler d1 create my-database # Create serverless SQLite databases

### Tips:
- JSONC = JSON with Comments
