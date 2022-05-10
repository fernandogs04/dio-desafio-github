function mudarMode () {
    body.classList.toggle("dark-mode");
    botao.classList.toggle("dark-mode");
    footer.classList.toggle("dark-mode");

    if (texto.textContent.endsWith("ON")) {
        texto.textContent = "Light Mode OFF";
    }
    else {
        texto.textContent = "Light Mode ON";
    }
}

const body = document.getElementsByTagName("body")[0];
const texto = document.getElementById("page-title");
const botao = document.getElementById("mode-selector");
const footer = document.getElementsByTagName("footer")[0];

botao.addEventListener("click", mudarMode);