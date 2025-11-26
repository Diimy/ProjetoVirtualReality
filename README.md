# 🏰 Projeto VR Medieval Dungeon Survival

Um jogo em Realidade Virtual desenvolvido em Unity, onde você assume o papel de um camponês medieval preso em um calabouço após não pagar seus impostos. Com apenas sua coragem e armas improvisadas, você deve sobreviver a ataques constantes de esqueletos, utilizando armas corpo a corpo e evitando morrer enquanto tenta se libertar do calabouço.

Este projeto foi desenvolvido para Meta Quest 2 utilizando **XR Interaction Toolkit**, **AI Navigation**, **NavMesh**, animações, interações físicas e HUD VR.

---

## 🎥 Vídeo demonstrativo do projeto


É possível visualizar o vídeo do jogo sendo executado [aqui](https://youtu.be/sBhUWilfXds)


---

## 🛠 Tecnologias Utilizadas

- **Unity 6000.3**
- **Meta Quest 2**
- **XR Interaction Toolkit (3.x)**
- **AI Navigation / NavMesh**
- **C#**
- **VR Locomotion (Smooth Locomotion)**
- **XR Grab Interactable (armas)**


---

## 🎮 Como Jogar

- Use o **analógico esquerdo** para andar (Smooth Locomotion)
- Pegue armas espalhadas pela dungeon com os gatilhos
- Bata nos esqueletos para derrotá-los
- Não deixe os inimigos encostarem em você
- Você possui **5 vidas**, exibidas como corações no HUD
- Ao perder uma vida, você **respawna**
- Um novo inimigo sempre nasce após cada morte (sua ou do inimigo)

---

## ⚔️ Mecânicas Implementadas

### 👤 Jogador
- Sistema de vidas com HUD de corações (estilo Super Mario)
- Respawn ao sofrer dano
- Movimentação suave via locomotion provider
- Interação VR com controllers (quest 2)

### ☠️ Inimigos (Esqueletos)
- IA baseada em NavMesh (perseguição do jogador)
- Animações de idle/walk via Blend Tree
- Colisão com o jogador causa dano
- Morte ao tomar dano físico das armas
- Sistema de respawn automático via EnemySpawner

### 🪓 Armas
- Espada, martelo, bastão e escudo
- Pegáveis usando XR Grab Interactable
- Dano baseado em velocidade de impacto (colisão física)
- Interação realista com colisores

### 🏰 Cenário
- Dungeon medieval modular
- NavMesh configurado para navegação do inimigo
- Lighting configurado com base em cena referência
- HUD em World Space anexado à câmera


---

## 📜 Scripts Principais

### **PlayerLife.cs**
- Controla vidas do jogador
- Atualiza HUD de corações
- Responsável pelo respawn

### **EnemyAI.cs**
- IA de perseguição
- Ataque ao jogador
- Morte ao tomar dano
- Comunicação com EnemySpawner

### **EnemySpawner.cs**
- Gera novo inimigo quando o atual morre
- Permite respawn infinito ou controlado

### **WeaponDamage.cs**
- Calcula velocidade da arma
- Aplica dano ao inimigo com base no impacto

### **HeartUIController.cs**
- Controla exibição de corações no HUD

---

## 👾 Como Buildar para Meta Quest 2

1. **Project Settings → XR Plug-in Management**
   - Android → OpenXR ON
   - Meta Quest Support ON
   - Oculus Touch Controller Profile ON

2. **Player Settings**
   - Target API Level: 29+
   - Scripting Backend: IL2CPP
   - ARM64 ativado

3. **Switch Platform para Android**
4. **Build and Run** com o Quest conectado via USB

---





