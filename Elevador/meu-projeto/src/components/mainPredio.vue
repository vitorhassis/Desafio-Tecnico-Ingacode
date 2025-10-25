<script setup>
import { ref } from "vue";
import andar from "./andar.vue";
import painel from "./painel.vue";

const andarAtual = ref(1);
const emMovimento = ref(false);
const filaAndares = ref([]);
const somElevador = new Audio("/elevador.mp3");
let tempoRetorno; 

function irPara(destino) {
  clearTimeout(tempoRetorno); 
  if (filaAndares.value.includes(destino)) return;
  filaAndares.value.push(destino);
  if (!emMovimento.value) atenderProximo();
}

function atenderProximo() {
  if (filaAndares.value.length === 0) {
    emMovimento.value = false;
    tempoRetorno = setTimeout(() => {
      if (andarAtual.value !== 1) moverElevador(1);
    }, 3000);
    return;
  }
  emMovimento.value = true;
  const destino = filaAndares.value.shift();
  moverElevador(destino);
}

function moverElevador(destino) {
  const direcao = destino > andarAtual.value ? 1 : -1;
  function mover() {
    if (andarAtual.value === destino) {
      somElevador.play();
      setTimeout(atenderProximo, 1000);
      return;
    }
    andarAtual.value += direcao;
    setTimeout(mover, 1000);
  }
  mover();
}

function subirUm() {
  clearTimeout(tempoRetorno);
  if (andarAtual.value < 4 && !emMovimento.value) {
    andarAtual.value++;
    somElevador.play();
  }
}

function descerUm() {
  clearTimeout(tempoRetorno);
  if (andarAtual.value > 1 && !emMovimento.value) {
    andarAtual.value--;
    somElevador.play();
  }
}
</script>

<template>
  <section class="flex flex-col items-center justify-center h-screen">
    <div class="flex">
      <div
        class="border border-black w-[350px] h-[750px] flex flex-col p-12 gap-8 justify-center items-center"
      >
        <h2 class="text-4xl text-red-400 font-bold">
          INGA<span class="text-blue-400">CODE</span>
        </h2>
        <andar
          v-for="num in [4, 3, 2, 1]"
          :key="num"
          :class="[
            'transition-all duration-500 border w-full flex items-center justify-center text-xl font-bold',
            andarAtual === num ? 'bg-yellow-300' : 'bg-white',
          ]"
        >
          {{ num }}
        </andar>
      </div>
      <painel @chamar="irPara" @subir="subirUm" @descer="descerUm" />
    </div>
    <div class="border border-black w-full"></div>
  </section>
</template>
