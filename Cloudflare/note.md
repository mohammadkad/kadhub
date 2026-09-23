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

### python packaging: https://developers.cloudflare.com/workers/languages/python/packages/
### Examples: https://github.com/cloudflare/python-workers-examples
## Python + FastAPI: <!-- 1405-06-31 -->
### 1. Install uv (if you don't have it yet)
- curl -LsSf https://astral.sh/uv/install.sh | sh
- uv tool install workers-py // install globally

### 2. Install project dependencies (fastapi, workers-py, workers-runtime-sdk)
cd my-worker
uv sync

### 3. Authenticate with Cloudflare (opens a browser window)
- uv run pywrangler --help
- uv run pywrangler login

### 4. (Optional) run it locally first at http://localhost:8787
uv run pywrangler dev

### 5. Audit the bundle locally before deploying
uv run pywrangler deploy --dry-run --outdir dist

### 5. Deploy to Cloudflare's edge
uv run pywrangler deploy
