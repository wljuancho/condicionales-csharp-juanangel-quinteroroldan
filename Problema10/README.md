# Problema 10. Analizador de datos recibidos

**Estructura elegida:** `switch` con patrones de tipo.

**Justificación:** cada tipo concreto almacenado en `object` necesita una descripción diferente.

**Ejecución:** ingresa texto, un entero, un decimal o un booleano.

**Ejemplos:** `SENA` → `Texto de 4 caracteres`; `42` → `Entero: 42`; `true` → `Booleano: True`.

**Evidencia:**

![Salida](evidencias/salida.png)
