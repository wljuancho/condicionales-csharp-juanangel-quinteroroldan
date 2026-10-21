# Problema 19. Radar de velocidad

**Estructura elegida:** expresión `switch` con patrones relacionales.

**Justificación:** los rangos contiguos de velocidad se expresan de forma ordenada y cubren todas las lecturas.

**Ejecución:** ingresa la velocidad en km/h.

**Ejemplos:** `45` → `Sin infracción`; `68` → `Multa leve`; `95` → `Multa gravísima e inmovilización`; `-1` → `Lectura inválida`.

**Evidencia:**

![Salida](evidencias/salida.png)
