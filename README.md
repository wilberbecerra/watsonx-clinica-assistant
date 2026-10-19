<div align="center">

![Image_Alt](https://github.com/wilberbecerra/watsonx-clinica-assistant/blob/e2eb7fac1823327e974409d2ed7bd74972a1a340/ClinicaAPI/assets/San%20Camilo%20Bot.png)

<h1>🏥 Clínica San Camilo - Asistente Virtual Inteligente (API REST)</h1>
</div>

Backend de integración transaccional entre **IBM watsonx Assistant** y **SQL Server**, diseñado para automatizar el triage de pacientes, el agendamiento autónomo de citas y la captura de leads comerciales.

Este proyecto demuestra la conexión de modelos cognitivos de Inteligencia Artificial en la nube con infraestructura de datos local mediante túneles seguros y APIs RESTful.

## 🚀 Arquitectura y Tecnologías
- **Backend:** C# (.NET 8), ASP.NET Core Web API
- **Inteligencia Artificial:** IBM watsonx Assistant (Procesamiento de Lenguaje Natural - NLP)
- **Base de Datos:** Microsoft SQL Server
- **ORM:** Dapper (Micro-ORM para consultas T-SQL optimizadas)
- **Documentación & Integración:** Swagger (OpenAPI 3.0), Ngrok (Túnel HTTP seguro)
- **Frontend:** HTML5, CSS3, JavaScript (Widget Embebido)

## ⚙️ Flujo del Sistema
1. El usuario interactúa con el widget web usando lenguaje natural.
2. **IBM watsonx Assistant** detecta las intenciones (*intents*) y entidades (*entities*).
3. Mediante su extensión OpenAPI, Watson envía un payload JSON a través de **Ngrok** hacia nuestra Web API en **.NET**.
4. El controlador procesa la solicitud mediante **Dapper** e inserta el registro transaccional en **SQL Server**.

## 📌 Endpoints Principales
La API expone endpoints específicos para ser consumidos por el modelo de IA:

- `POST /api/Citas/crear`: Valida y registra una nueva cita médica en la base de datos.
- `POST /api/Citas/registrarContacto`: Captura datos de prospectos (leads) que solicitan comunicación directa con un asesor humano.
- `GET /api/Citas/consultar`: Retorna el historial de registros ordenados de forma descendente.

## 📸 Demostración Visual

### 1. Interfaz del Asistente Virtual
![Image_Alt]([https://github.com/wilberbecerra/watsonx-clinica-assistant/blob/main/assets/chat-bot-san-camilo.jpg](https://github.com/wilberbecerra/watsonx-clinica-assistant/blob/e2eb7fac1823327e974409d2ed7bd74972a1a340/ClinicaAPI/assets/chat-bot-san-camilo.jpg))

### 2. Árboles de Diálogo e Intenciones (IBM watsonx)

**Flujo: Agendar Cita**
![Image_Alt](https://github.com/wilberbecerra/watsonx-clinica-assistant/blob/e2eb7fac1823327e974409d2ed7bd74972a1a340/ClinicaAPI/assets/Agendar%20Cita.png)

**Flujo: Hablar con un Asesor Humano**
![Image_Alt](https://github.com/wilberbecerra/watsonx-clinica-assistant/blob/e2eb7fac1823327e974409d2ed7bd74972a1a340/ClinicaAPI/assets/Hablar%20con%20un%20Asesor%20Humano.png)

**Flujo: Información General**
![Image_Alt](https://github.com/wilberbecerra/watsonx-clinica-assistant/blob/e2eb7fac1823327e974409d2ed7bd74972a1a340/ClinicaAPI/assets/Informaci%C3%B3n%20General.png)
