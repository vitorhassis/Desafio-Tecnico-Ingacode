<h2 align="center">💻 Desafio Técnico em C# .NET | IngaCode 💻</h2>

## 📌 Sobre o Projeto

Repositório destinado aos **desafios técnicos propostos pela IngaCode**, desenvolvidos em **C# (.NET Console)** e **Vue.js**, com foco em **lógica de programação, estruturas de controle, eventos e manipulação de dados**.

Cada desafio representa um teste prático de raciocínio lógico e domínio da linguagem, explorando **coleções genéricas**, **eventos e handlers**, **métodos**, **loops**, **manipulação de arquivos**, **validação de entrada** e **interação visual**.

---

## ⚙️ Tecnologias e Recursos Utilizados

* 🧠 **C# (.NET 8 Console Application)**
* 🌐 **Vue.js 3 + Vite**
* 🎨 **Tailwind CSS** – Estilização responsiva e visual interativo
* 🔁 **Estruturas de repetição:** `while`, `for`, `setTimeout`
* 🧩 **Condicionais:** `if/else`, `switch`
* 🗂️ **Coleções genéricas:** `Dictionary<TKey, TValue>`
* 🎮 **Eventos e emitters (Vue)** – Manipulação de chamadas e botões
* 🧾 **Manipulação de strings:** `ToUpper()`, concatenação e formatação
* 💾 **System.IO.StreamWriter** – Gravação de arquivos locais (senhas geradas)
* 🔒 **System.Security.Cryptography.RandomNumberGenerator** – Geração de caracteres aleatórios seguros
* ⚙️ **Boas práticas:** Modularização, reutilização de métodos, clareza de código e reatividade

---

## 🧠 Desafios Implementados

### **1️⃣ Conversor de Números Romanos**

* Conversão **Romano → Decimal** e **Decimal → Romano** via **dicionários**.
* Aplicação de **regras de subtração condicional** (ex: IV = 4, IX = 9).
* Estrutura de **menu interativo**, com controle de fluxo e repetição via `bool continuar`.
* Uso de **método auxiliar** para exibir títulos e limpar apenas o contexto atual.

### **2️⃣ Gerador de Senhas**

* Geração de senhas **personalizadas e seguras** com parâmetros configuráveis:
    * Letras maiúsculas
    * Letras minúsculas
    * Números
    * Símbolos especiais
    * Emojis
* Utilização de **RandomNumberGenerator** para entropia criptográfica.
* Armazenamento das senhas geradas em arquivo `.txt` local via **StreamWriter**.
* Estrutura modular e interação direta com o usuário via console.

### **3️⃣ Simulador de Elevador (Vue.js)**

* Desenvolvimento de uma **simulação interativa de elevador** utilizando **Vue.js + Tailwind CSS**.
* Implementação de **eventos e manipuladores** entre componentes (`painel.vue`, `andar.vue`, `mainPredio.vue`).
* O usuário pode:
    * Selecionar múltiplos andares em sequência (fila de atendimento).
    * Ouvir um **som de chegada** ao alcançar um andar (`/public/elevador.mp3`).
    * Usar **botões de seta** para subir ou descer manualmente.
    * Ver o elevador **retornar automaticamente ao primeiro andar** após inatividade.
* Lógica baseada em **reatividade (`ref`)** e **controle de eventos (`emit`)**.
* Interface responsiva e visual limpa utilizando **Tailwind CSS**.

---

## 🧩 Execução dos Desafios

### **Desafios 1 & 2 (C# .NET Console)**

Estes projetos são aplicações console e podem ser executados via terminal ou diretamente pelo Visual Studio.

**Pré-requisito:** .NET SDK 8.0 instalado.

#### **Opção 1: Via Linha de Comando (Terminal)**

1.  Abra o terminal na pasta raiz do repositório (`Desafio-Tecnico-Ingacode`).
2.  Acesse a pasta do projeto C# (que contém o arquivo `.csproj`):

    ```bash
    # Para o Conversor de Romanos (Desafio 1)
    cd ConversorNumerico/desafio01 
    
    # Para o Gerador de Senhas (Desafio 2)
    # cd GeradorSenhas/GeradorSenha
    ```

3.  Execute a aplicação:

    ```bash
    dotnet run
    ```

#### **Opção 2: Via Visual Studio**

1.  Abra o **Visual Studio**.
2.  No menu `Arquivo`, selecione `Abrir` -> `Projeto/Solução`.
3.  Navegue até o arquivo de solução (`.sln`) dentro da pasta principal de cada desafio:
    * `ConversorNumerico/desafio01.sln`
    * `GeradorSenhas/GeradorSenha.sln`
4.  Após o carregamento, certifique-se de que o projeto correto esteja selecionado como **Startup Project** (Projeto de Inicialização).
5.  Pressione o botão **Start** (ou `F5`) para compilar e executar a aplicação.

### **Desafio 3 (Vue.js + Vite)**

1.  Certifique-se de ter o **Node.js** instalado ([Download Node.js](https://nodejs.org/)).

2.  Acesse a pasta do projeto Vue:

    ```bash
    cd Elevador/meu-projeto
    ```

3.  Instale as dependências:

    ```bash
    npm install
    ```

4.  Execute o servidor:

    ```bash
    npm run dev
    ```

5.  Acesse o link exibido no terminal (geralmente `http://localhost:5173/`).
   
---

## 📩 Contato

📧 **Email:** [vitorassis997@gmail.com](mailto:vitorassis997@gmail.com)  
👨‍💻 **GitHub:** [github.com/vitorhassis](https://github.com/vitorhassis)

---

<p align="center">⚡ <em>Desenvolvido por Vitor Assis — Desafio Técnico IngaCode</em> ⚡</p>
