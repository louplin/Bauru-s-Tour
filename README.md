<div align="center">

# 🗺️ Bauru's Tour

### *Qual área vamos explorar hoje?*

Um guia desktop para descobrir a **história, a cultura e os pontos turísticos** de Bauru-SP.

![C#](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=csharp&logoColor=white)
![.NET](https://img.shields.io/badge/.NET-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)
![Windows Forms](https://img.shields.io/badge/Windows%20Forms-0078D6?style=for-the-badge&logo=windows&logoColor=white)
![JSON](https://img.shields.io/badge/JSON-000000?style=for-the-badge&logo=json&logoColor=white)
![Status](https://img.shields.io/badge/status-em%20desenvolvimento-B84FE8?style=for-the-badge)

</div>

---

## 📖 Sobre o projeto

**Bauru's Tour** é um aplicativo desktop que reúne, em um só lugar, os principais pontos turísticos de Bauru: parques, museus, teatro, centros culturais e muito mais.

A ideia é simples: o usuário digita o que quer conhecer, busca, e recebe uma lista de lugares com informações claras, endereço e link direto para o mapa.

O projeto nasceu como trabalho da faculdade e também como uma forma de aprender **arquitetura de software** na prática, separando tela, regras e dados em camadas bem definidas.

## 🎯 Para quem é

| Público | Como o app ajuda |
|---|---|
| 🧳 **Turistas** | Descobrir o que visitar e como chegar |
| 🏠 **Moradores de Bauru** | Redescobrir a história e a cultura da própria cidade |
| 🎓 **Estudantes (14+)** | Conhecer o patrimônio local de forma leve e visual |

---

## ✨ Ideias e funcionalidades

- [x] 🏁 **Tela inicial** com o convite *"Começar minha jornada"*
- [x] 🔎 **Tela de busca** com campo de pesquisa e botão **Buscar**
- [x] 📦 **Base de dados** em JSON com **21 pontos turísticos** divididos em **4 categorias**
- [x] 🧱 **Camadas de Models e Data** funcionando
- [ ] 📋 **Lista de resultados** exibida ao clicar em *Buscar*
- [ ] 🧠 **Camada de Services** com busca por **nome** e por **categoria**
- [ ] 🖼️ **Tela de detalhes** com imagem, descrição e endereço do ponto
- [ ] 📍 Botão **"Abrir no Maps"** usando o link de cada local
- [ ] 🎨 Filtro rápido por categoria

---

## 🖼️ Telas

> Adicione aqui as capturas de tela do app (veja a dica no final do arquivo).

<div align="center">

| Tela de busca |
|:---:|
| ![Tela de busca](docs/tela-busca.png) |

</div>

---

## 🏗️ Arquitetura

O projeto segue a ideia de **separar responsabilidades**: cada camada faz uma coisa só e conversa apenas com a vizinha.

```
┌─────────────────────────────┐
│   Interface (Windows Forms) │   ← o que o usuário vê e clica
└──────────────┬──────────────┘
               │
┌──────────────▼──────────────┐
│   Services                  │   ← regras: buscar por nome, filtrar por categoria
└──────────────┬──────────────┘
               │
┌──────────────▼──────────────┐
│   Data                      │   ← leitura do arquivo JSON
└──────────────┬──────────────┘
               │
┌──────────────▼──────────────┐
│   Models                    │   ← o formato de um Ponto Turístico
└─────────────────────────────┘
```

### 📐 Modelo de dados

Cada ponto turístico no `pontos.json` possui:

| Campo | Descrição |
|---|---|
| `Id` | Identificador único do ponto |
| `Nome` | Nome do local |
| `Descricao` | Texto explicando a história e o que o lugar oferece |
| `Imagem` | Foto do local |
| `Categoria` | Grupo ao qual o ponto pertence |
| `Endereco` | Endereço para visita |
| `LinkMaps` | Link direto para o local no mapa |

---

## 🛠️ Tecnologias

- **C#** com **.NET**
- **Windows Forms** para a interface desktop
- **JSON** para armazenar os dados (sem banco de dados, de propósito: simples e portátil)
- **Git e GitHub** para versionamento
- **Asana** para organizar e planejar as tarefas

---

## 🚀 Como executar

**Pré-requisitos:** Windows, [.NET SDK](https://dotnet.microsoft.com/download) e Visual Studio 2022 ou superior.

```bash
# 1. Clone o repositório
git clone https://github.com/viniciuscury147-spec/Bauru-s-Tour.git

# 2. Entre na pasta
cd Bauru-s-Tour

# 3. Abra a solução no Visual Studio e pressione F5
```

---

## 🧭 Roadmap

```
✅ Definir tema, público e dados
✅ Criar modelos e leitura do JSON
✅ Desenhar tela inicial e tela de busca
🔜 Exibir lista de resultados na busca
🔜 Implementar busca por nome e categoria
🔜 Tela de detalhes do ponto turístico
🔜 Integração com o link do mapa
```

---

## 👨‍💻 Autores

Feito com 💜 por

**Vinicius Cury**

[![GitHub](https://img.shields.io/badge/GitHub-181717?style=for-the-badge&logo=github&logoColor=white)](https://github.com/viniciuscury147-spec)
[![LinkedIn](https://img.shields.io/badge/LinkedIn-0A66C2?style=for-the-badge&logo=linkedin&logoColor=white)](https://www.linkedin.com/in/SEU-PERFIL)

**Luis Otavio P.**

[![GitHub](https://github.com/luispavanato)
[![LinkedIn](https://www.linkedin.com/in/luis-otávio-capoani-pavanato-613b1a378?utm_source=share_via&utm_content=profile&utm_medium=member_ios)

**Mathues Faria.

[![GitHub](https://github.com/louplin)
[![LinkedIn](https://www.linkedin.com/in/matheusqfaria/)

**Gustavo**

[![GitHub]
[![LinkedIn]



<div align="center">

*Bauru's Tour: conheça a cidade, um ponto de cada vez.* 🗺️

</div>
