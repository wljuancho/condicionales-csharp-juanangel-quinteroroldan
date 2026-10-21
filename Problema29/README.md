# Problema 29. Control de acceso a la sede

**Estructura elegida:** expresión `switch` por rol con patrones de rango.

**Justificación:** cada rol tiene una regla horaria distinta y el patrón permite expresarla de forma directa.

**Ejecución:** ingresa el rol y la hora de llegada entre 0 y 23.

**Ejemplos:** `admin`, `2` → `Acceso permitido`; `instructor`, `20` → `Acceso permitido`; `aprendiz`, `19` → `Acceso denegado`.

**Evidencia:**

![Salida](evidencias/salida.png)
