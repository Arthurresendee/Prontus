# Prontus - Sistema de Gestão Odontológica

Sistema SaaS para gestão de clínicas odontológicas, desenvolvido com tecnologias modernas e arquitetura multi-tenant.

## 🚀 Tecnologias

### Backend
- ASP.NET Core Web API (.NET 8)
- MongoDB
- JWT Authentication
- Clean Architecture

### Frontend Web
- Next.js
- Tailwind CSS
- Zustand/Redux Toolkit
- Axios

### Mobile
- React Native
- Expo (opcional)
- Zustand/Redux

## 📁 Estrutura do Projeto

```
prontus/
├── backend/            # ASP.NET Core API
├── frontend/           # Next.js Web App
├── mobile/            # React Native App
├── shared/            # Tipos compartilhados / utilitários
└── docs/              # Documentação
```

## 🛠️ Requisitos

- .NET 8 SDK
- Node.js 18+
- MongoDB
- Docker (opcional)

## 🚀 Como executar

### Backend
```bash
cd backend
dotnet restore
dotnet run
```

### Frontend Web
```bash
cd frontend
npm install
npm run dev
```

### Mobile
```bash
cd mobile
npm install
npm run start
```

## 📝 Licença

Este projeto está sob a licença MIT. Veja o arquivo [LICENSE](LICENSE) para mais detalhes. 