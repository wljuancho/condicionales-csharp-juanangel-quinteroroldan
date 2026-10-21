# Problema 25. Calidad del aire

**Estructura elegida:** expresión `switch` con patrones relacionales.

**Justificación:** los intervalos crecientes del ICA se comprueban en orden y cada uno produce una categoría.

**Ejecución:** ingresa un valor entero de ICA.

**Ejemplos:** `35` → `Buena`; `120` → `Dañina para grupos sensibles`; `260` → `Muy dañina`; `-1` → `Valor inválido`.

**Evidencia:**

![Salida](evidencias/salida.png)
