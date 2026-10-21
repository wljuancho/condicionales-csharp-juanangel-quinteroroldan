# Problema 28. Descuento por compra

**Estructura elegida:** expresión `switch` por rangos y condición adicional.

**Justificación:** el valor de la compra define el descuento base y el estado de cliente frecuente agrega cinco puntos porcentuales desde $100.000.

**Ejecución:** ingresa el valor de compra y si el cliente pertenece al programa frecuente.

**Ejemplos:** `$250.000`, frecuente → descuento `15%`, total `$212.500`; no frecuente → `10%`, `$225.000`; `$80.000`, frecuente → `0%`, `$80.000`.

**Evidencia:**

![Salida](evidencias/salida.png)
