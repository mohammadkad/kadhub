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
- npx wrangler d1 create my-database
