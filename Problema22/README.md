# Problema 22. Calculadora básica

**Estructura elegida:** expresión `switch` y validación condicional.

**Justificación:** el operador selecciona una operación exacta, mientras que la división requiere controlar explícitamente el divisor cero.

**Ejecución:** ingresa dos enteros y uno de los operadores `+`, `-`, `*` o `/`.

**Ejemplos:** `12`, `4`, `*` → `12 * 4 = 48`; divisor cero → excepción `No se puede dividir entre cero`; `%` → excepción `Operador no soportado`.

**Evidencia:**

![Salida](evidencias/salida.png)
