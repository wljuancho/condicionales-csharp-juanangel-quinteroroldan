# Problema 30. Boletín de calificaciones

**Estructura elegida:** expresiones `switch` por rangos y por letra, más operador ternario.

**Justificación:** el promedio se clasifica por intervalos, cada letra tiene retroalimentación y la aprobación depende del umbral de 60.

**Ejecución:** ingresa tres notas entre 0 y 100.

**Ejemplo:** `85`, `78`, `92` → `Promedio: 85,0 | Letra: B | Buen desempeño, sigue así | Aprobado`; tres notas de `100` también muestran `¡Mención de honor!`.

**Evidencia:**

![Salida](evidencias/salida.png)
