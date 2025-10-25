<script setup>
defineProps({
    numero:Number
});
</script>

<template>
   <button
    class="border border-gray-700 rounded-full w-12 h-12 flex items-center justify-center bg-gray-100 hover:bg-gray-300" 
  >
    {{ numero }}
  </button>
</template>


