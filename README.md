# Karting Game with ML-Agents 🏎️🤖

Este proyecto utiliza **Unity ML-Agents** para entrenar agentes autónomos en un juego de karts. El objetivo es entrenar agentes que puedan competir en una pista de carreras, ajustando sus comportamientos a diferentes niveles de dificultad y modelos de control neuronal.

## Tabla de Contenidos

- [Características](#características)
- [Requisitos](#requisitos)
- [Instalación](#instalación)
- [Uso](#uso)
  - [Entrenamiento](#entrenamiento)
  - [Evaluación](#evaluación)
  - [Configuración del Juego](#configuración-del-juego)
- [Estructura del Proyecto](#estructura-del-proyecto)
- [Contribuciones](#contribuciones)
- [Licencia](#licencia)

## Características

- **Entrenamiento con Currículo**: Los agentes se entrenan con tareas de dificultad creciente.
- **Modelos de Cerebro (Brain Models)**: Diferentes modelos ONNX se pueden seleccionar y asignar a los bots.
- **Ajustes de Dificultad**: Los jugadores pueden elegir entre diferentes niveles de dificultad que afectan la velocidad y el comportamiento de los karts.
- **Checkpoints**: Los agentes deben aprender a navegar por una pista siguiendo checkpoints distribuidos por el mapa.

## Requisitos

- **Unity 2020.3 o superior**.
- **ML-Agents Toolkit 0.26.0 o superior**.
- **Python 3.8 o superior**.
- **Paquetes necesarios**: `mlagents`, `numpy`, `torch`, `gym`, `tensorflow` (para la compatibilidad con modelos ONNX).
- **CUDA** (opcional, para acelerar el entrenamiento con GPUs NVIDIA).

## Instalación

### Paso 1: Clonar el Repositorio

```bash
git clone https://github.com/tu-usuario/karting-ml-agents.git
cd karting-ml-agents
```bash

### Paso 2: Configurar el Entorno Python
Es recomendable utilizar un entorno virtual para gestionar las dependencias de Python:

```bash
python -m venv venv
source venv/bin/activate  # En Windows: venv\Scripts\activate
pip install -r requirements.txt
