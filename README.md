# Karting Game with ML-Agents 🏎️🤖

Este proyecto utiliza **Unity ML-Agents** para entrenar agentes autónomos en un juego de karts. El objetivo es entrenar agentes que puedan competir en una pista de carreras, ajustando sus comportamientos a diferentes niveles de dificultad y modelos de control neuronal.

## Tabla de Contenidos

- [Características](#características)
- [Requisitos](#requisitos)
- [Instalación](#instalación)
- [Uso](#uso)
- [Entrenamiento](#entrenamiento)
- [Evaluación](#evaluación)

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
git clone https://github.com/YudaLegend/TFG-ML-AGENTS.git
```

### Paso 2: Configurar el Entorno Python
Es recomendable utilizar un entorno virtual para gestionar las dependencias de Python:

```bash
python -m venv venv
source venv/bin/activate  # En Windows: venv\Scripts\activate
- pip install mlagents
- pip install mlagents_envs
- pip install gym_unity
- pip install torch
```

### Paso 3: Configurar Unity
1.Abre Unity Hub y añade el proyecto que clonaste (karting-ml-agents).

2.Importa el paquete ML-Agents desde el gestor de paquetes de Unity.

3.Asegúrate de configurar correctamente los Brains.

### Uso
Aqui tienes un link de un ejemplo de como configurar los parametros de behaviour en Unity.

https://github.com/Unity-Technologies/ml-agents/blob/main/docs/Getting-Started.md

### Entrenamiento
Para entrenar a los bots de karting:

Configura los parámetros de entrenamiento en el archivo trainer_config.yaml.

Corre el entrenamiento desde la terminal de Python:
```bash
mlagents-learn config/trainer_config.yaml --run-id=karting_run
```
El entrenamiento puede llevar tiempo. Observa el progreso desde la ventana del TensorBoard:

```bash
tensorboard --logdir="results"
```
### Evaluación
Una vez que el modelo está entrenado, puedes cargar el modelo entrenado en Unity:

Dirígete al agente de kart y asigna el modelo entrenado en su Behavior Parameters.
Ejecuta el juego desde Unity y observa cómo los bots navegan por la pista.


un video de ejemplo para observar el comporatamiento de un modelo en un circuito.
[Ver el video de la simulación](TFG-ML-AGENTS/TFG-NPC-s-Karting-Game Models/Modelo Continuo Evolucion/Modelo de 13 Sensores mejorado)
