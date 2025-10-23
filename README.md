<h2 align="center">🚧 EM CONSTRUÇÃO 🚧<br>💻 Desafio Técnico em C# .NET | IngaCode 💻</h2>

## 📌 Sobre o projeto

Repositório destinado aos **desafios técnicos propostos pela IngaCode**, desenvolvidos em **C# (.NET Console)** com foco em **lógica de programação, estruturas de controle e manipulação de dados**.  

Cada desafio representa um teste prático de raciocínio lógico e domínio da linguagem, explorando **coleções genéricas**, **dicionários**, **métodos**, **loops**, **manipulação de arquivos** e **validação de entrada**.

---

## ⚙️ Tecnologias e recursos utilizados

- 🧠 **C# (.NET 8 Console Application)**  
- 🔁 **Estruturas de repetição:** `while`, `for`  
- 🧩 **Condicionais:** `if/else`, `switch`  
- 🗂️ **Coleções genéricas:** `Dictionary<TKey, TValue>`  
- 🧾 **Manipulação de strings:** `ToUpper()`, concatenação e formatação  
- 💾 **System.IO.StreamWriter** – gravação de arquivos locais (senhas geradas)  
- 🔒 **System.Security.Cryptography.RandomNumberGenerator** – geração de caracteres aleatórios seguros  
- 🎨 **System.Console** – cores e formatação visual  
- ⚙️ **Boas práticas:** modularização, reutilização de métodos e clareza de código  

---

## 🧠 Desafios Implementados

### **1️⃣ Conversor de Números Romanos**
- Conversão **Romano → Decimal** e **Decimal → Romano** via **dicionários**.  
- Aplicação de **regras de subtração condicional** (ex: IV = 4, IX = 9).  
- Estrutura de **menu interativo**, com controle de fluxo e repetição via `bool continuar`.  
- Uso de **método auxiliar** para exibir títulos e limpar apenas o contexto atual.  

### **2️⃣ Gerador de Senhas**
- Geração de senhas **personalizadas e seguras** com parâmetros configuráveis:  
  - Letras maiúsculas  
  - Letras minúsculas  
  - Números  
  - Símbolos especiais
  - Emojis
- Utilização de **RandomNumberGenerator** para entropia criptográfica.  
- Armazenamento das senhas geradas em arquivo `.txt` local via **StreamWriter**.  
- Estrutura modular e interação direta com o usuário via console.

### **3️⃣ Desafio em Desenvolvimento 🚧**
- *(Em construção – será adicionado em breve.)*  

---

## 📂 Estrutura do Repositório
```
desafios-ingacode-csharp/
├── desafio01-conversor-romano/
│ ├── ConversaoRomano.cs
│ ├── Entrada.cs
│ └── Program.cs
│
├── desafio02-gerador-senhas/
│ ├── GeradorSenha.cs
│ ├── Entrada.cs
│ └── Program.cs
│
└── README.md
```


---

## 🧩 Execução

1. Certifique-se de ter o **.NET SDK** instalado ([Download .NET](https://dotnet.microsoft.com/download)).  
2. Clone este repositório e acesse a pasta do desafio desejado:
   ```bash
   git clone https://github.com/vitorhassis/desafios-ingacode-csharp.git
   cd desafios-ingacode-csharp/desafio01-conversor-romano
   dotnet run


---

## 📩 Contato

📧 **Email:** [vitorassis997@gmail.com](mailto:vitorassis997@gmail.com)  
👨‍💻 **GitHub:** [github.com/vitorhassis](https://github.com/vitorhassis)

---


<p align="center">⚡ <em>Desenvolvido por Vitor Assis — Desafio Técnico IngaCode</em> ⚡</p>
