<script setup>
import botaoPainel from "./botaoPainel.vue"

const emit = defineEmits(["chamar", "subir", "descer"])

function chamar(andar) {
  emit("chamar", andar)
}
</script>

<template>
  <section
    class="border border-black w-[250px] h-[300px] ml-13 flex justify-between p-8"
  >
  
    <div class="flex flex-col gap-4">
      <botaoPainel
        v-for="num in [4, 3, 2, 1]"
        :key="num"
        :numero="num"
        @click="chamar(num)"
      />
    </div>

    <div class="flex flex-col gap-4">
      <button
        class="border p-8 text-2xl bg-gray-100 hover:bg-gray-300"
        @click="emit('subir')"
      >
        ⬆
      </button>
      <button
        class="border p-8 text-2xl bg-gray-100 hover:bg-gray-300"
        @click="emit('descer')"
      >
        ⬇
      </button>
    </div>
  </section>
</template>
