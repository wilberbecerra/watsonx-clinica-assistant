<div align="center">
  <img src="https://github.com/wilberbecerra/watsonx-clinica-assistant/blob/main/ClinicaAPI/assets/logo-san-camilo-chat-bot-sf.png?raw=true" alt="Logo San Camilo Bot Sin Fondo" width="140" />
  <h1>🏥 Clínica San Camilo - Asistente Virtual Inteligente (API REST)</h1>
  <p><em>Integración transaccional Cloud-to-OnPremise con IBM watsonx Assistant, .NET 8 y SQL Server</em></p>
</div>

---

Backend de integración transaccional entre **IBM watsonx Assistant** y **SQL Server**, diseñado para automatizar el triage de pacientes, el agendamiento autónomo de citas y la captura de leads comerciales.

Este proyecto demuestra la conexión de modelos cognitivos de Inteligencia Artificial en la nube con infraestructura de datos local mediante túneles seguros y APIs RESTful.

## 🚀 Arquitectura y Tecnologías

| Capa / Rol | Tecnología Implementada |
| :--- | :--- |
| **Backend & API** | C# (.NET 8), ASP.NET Core Web API |
| **Inteligencia Artificial** | IBM watsonx Assistant (Procesamiento de Lenguaje Natural - NLP) |
| **Base de Datos** | Microsoft SQL Server (Transaccional) |
| **Acceso a Datos (ORM)** | Dapper (Micro-ORM para consultas T-SQL optimizadas) |
| **Documentación & Red** | Swagger (OpenAPI 3.0), Ngrok (Túnel HTTP seguro) |
| **Frontend** | HTML5, CSS3, JavaScript (Widget Embebido) |

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

---

## 📸 Galería del Sistema (Screenshots)

### 💬 Interfaz del Asistente Virtual (UI)

| Identidad del Asistente | Widget Conversacional en Vivo |
| :---: | :---: |
| <img src="https://github.com/wilberbecerra/watsonx-clinica-assistant/blob/main/ClinicaAPI/assets/San%20Camilo%20Bot.png?raw=true" width="220" alt="San Camilo Bot" /> | <img src="https://github.com/wilberbecerra/watsonx-clinica-assistant/blob/main/ClinicaAPI/assets/chat-bot-san-camilo.jpg?raw=true" width="260" alt="Interfaz Chatbot San Camilo" /> |
| *Asistente cognitivo entrenado en IBM Cloud* | *Menú interactivo para triage, citas y captura de leads* |

### 🤖 Árboles de Diálogo e Intenciones (IBM watsonx)

| Flujo: Agendar Cita | Flujo: Hablar con un Asesor | Flujo: Información General |
| :---: | :---: | :---: |
| ![Agendar Cita](https://github.com/wilberbecerra/watsonx-clinica-assistant/blob/main/ClinicaAPI/assets/Agendar%20Cita.png) | ![Hablar con un Asesor Humano](https://github.com/wilberbecerra/watsonx-clinica-assistant/blob/main/ClinicaAPI/assets/Hablar%20con%20un%20Asesor%20Humano.png) | ![Información General](https://github.com/wilberbecerra/watsonx-clinica-assistant/blob/main/ClinicaAPI/assets/Informaci%C3%B3n%20General.png) |
| *Captura de especialidad, fecha, DNI e inserción vía API en SQL Server* | *Derivación de casos complejos y registro de contacto comercial* | *Atención automatizada 24/7 de horarios, ubicación y preguntas frecuentes* |
