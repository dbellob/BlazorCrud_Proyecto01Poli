# BlazorCrud_Proyecto01

**Autores**
- David Bello
- Carlos Sabino

---

# Ejecutar el proyecto con Docker

## Requisitos

Antes de comenzar, asegúrate de tener instalado:

- Docker Desktop
- Docker Compose (incluido en Docker Desktop)

Verifica la instalación ejecutando:

```bash
docker --version
docker compose version
```

---

## 1. Abrir una terminal

Ubícate en la carpeta donde clonaste el proyecto.

Si estás en la carpeta padre:

```bash
cd BlazorCrud_Proyecto01
```

O reemplaza la ruta por la ubicación donde tengas el proyecto:

```bash
cd <ruta-del-proyecto>/BlazorCrud_Proyecto01
```

Por ejemplo:

**Windows**

```cmd
cd C:\Users\David\Documents\BlazorCrud_Proyecto01
```

**Linux / macOS**

```bash
cd ~/Documentos/BlazorCrud_Proyecto01
```

---

## 2. Verificar que estás en la carpeta correcta

Ejecuta:

**Linux / macOS**

```bash
ls
```

**Windows (CMD)**

```cmd
dir
```

Deberías visualizar una estructura similar a la siguiente:

```
BlazorCrud_Proyecto01.sln
docker-compose.yml
BlazorCrud_Proyecto01/
```

---

## 3. Construir las imágenes Docker

Para realizar una compilación limpia:

```bash
docker compose build --no-cache
```

---

## 4. Levantar los contenedores

Ejecuta:

```bash
docker compose up
```

O, si deseas construir y levantar en un solo comando:

```bash
docker compose up --build
```

Si deseas ejecutar los contenedores en segundo plano:

```bash
docker compose up -d
```

---

## 5. Acceder a la aplicación

Una vez los contenedores estén ejecutándose, abre tu navegador y entra a:

```
http://localhost:8003
```

---

## 6. Detener los contenedores

Para detener la ejecución:

```bash
Ctrl + C
```

Si los ejecutaste en segundo plano:

```bash
docker compose down
```

---

## Comandos útiles

Construir nuevamente:

```bash
docker compose build --no-cache
```

Levantar el proyecto:

```bash
docker compose up
```

Levantar reconstruyendo:

```bash
docker compose up --build
```

Ejecutar en segundo plano:

```bash
docker compose up -d
```

Ver los contenedores en ejecución:

```bash
docker ps
```

Detener los contenedores:

```bash
docker compose down
```