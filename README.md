# 🎮 Jogo da Forca Premium - Blazor WebAssembly

Um jogo da forca moderno, elegante e responsivo, desenvolvido com **Blazor WebAssembly** e focado em uma experiência de usuário premium com estética **Glassmorphism**.

![Blazor](https://img.shields.io/badge/WebAssembly-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)
![CSS3](https://img.shields.io/badge/CSS3-1572B6?style=for-the-badge&logo=css3&logoColor=white)

## ✨ Funcionalidades

-   **Estética Glassmorphism**: Interface moderna com fundos desfocados e efeitos translúcidos.
-   **Sistema de Temas Dinâmico**: Carregamento de palavras e dicas via arquivo JSON externo.
-   **Categorias Variadas**: Escolha entre Tecnologia, Animais, Países, Frutas, Esportes e Filmes.
-   **Suporte a Teclado Duplo**: Jogue usando o teclado virtual na tela ou o teclado físico do seu computador.
-   **Animações Suaves**: Feedback visual para acertos, erros e vitórias/derrotas.
-   **Totalmente Responsivo**: Otimizado para dispositivos móveis e desktop.

## 🛠️ Tecnologias Utilizadas

-   **C# / .NET 10**: Lógica de back-end rodando no navegador.
-   **Blazor WebAssembly**: Framework para criação de interfaces interativas.
-   **Vanilla CSS**: Estilização personalizada sem frameworks pesados.
-   **JSON**: Armazenamento flexível de dados do jogo.

## 🚀 Como Executar

### Pré-requisitos
-   [.NET SDK](https://dotnet.microsoft.com/download) instalado.

### Passos
1.  Clone este repositório:
    ```bash
    git clone https://github.com/seu-usuario/jogo-da-forca.git
    ```
2.  Navegue até a pasta do projeto:
    ```bash
    cd "JOGO DA FORCA"
    ```
3.  Execute o projeto:
    ```bash
    dotnet watch
    ```
4.  Abra o navegador no endereço indicado (geralmente `http://localhost:5246`).

## 📂 Estrutura do Projeto

-   `/Pages`: Contém a página principal do jogo (`Index.razor`).
-   `/Components`: Componentes reutilizáveis como Teclado, Desenho da Forca, etc.
-   `/Services`: Lógica de estado do jogo.
-   `/wwwroot/data`: Base de dados das palavras em formato JSON.

---
Desenvolvido com ❤️
