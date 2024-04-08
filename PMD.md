# Post Mortem: Poplloon

**Project date:  9th June, 2023 - (To be determinated)**

---

### Team Work:

- Albert Diaz Miravete:  Game director, Game Designer, Artist, QA, Programmer.

- Pablo Vázquez Romualdo: Programmer(Outsourcing).

---

# Introduction

"Poplloon" arose from a spontaneous inspiration triggered by a series of events in my personal life, leading to the conception of an innovative product within the saturated market of hyper-casual mobile games, with a unique and meaningful focus: accessibility for those affected by color deficiency, commonly known as color blindness.

The core gameplay concept was simple: popping colored balloons that appeared on the screen, with the twist that players were given an indication of which color to touch for points. 

However, if they touched the wrong color, they would be penalized.

In addition to this fundamental mechanic, the game featured additional elements such as obtaining power-ups and the appearance of plush toys tied to the balloons, providing a visually appealing aesthetic particularly suitable for the younger audience.

Unlike many games in the market, "Poplloon" didn't focus on player competition for the highest score but rather on providing a relaxing and enjoyable experience where players could enjoy at their own pace, without limits or external pressures.

Through this post-mortem, we will reflect on the achievements made, the challenges faced, and the lessons learned during "Poplloon's" journey towards creating an accessible and relaxing game for all.

---

### Positive aspects:

- The endearing aspect of the design and modeling of the plush toys that accompany the game's atmosphere received positive praise.

- With the assistance of Pablo Vázquez Romualdo, we implemented a complex database in the backend for the respective colorblind filters and color changes in the shading of the balloons, allowing for easy addition of more filters if desired in the future.

- The open/closed principle was utilized, allowing for straightforward extension of entities without the need to modify existing code.

---

### Challenges:

- The initial structure for the filters posed many scalability issues, which resulted in delays.

- Not setting a delivery deadline extended the project and caused demotivation, especially in the final stages of development, leading to frequent procrastination and postponements.

---

### Lessons learned:

- The importance of imposing a short to medium-term delivery deadline.

- The need to utilize agile work methodologies like SCRUM, to release prototype versions of the product and generate anticipation.

- The creation of a dev room would have been essential to test different backend programming models and establish the core mechanics more thoroughly.

---

### Project Successes and Initial Objectives:

- The main objective of ensuring the game provided an entertaining and relaxing experience in its initial versions for the adult casual target audience was achieved.

- However, some secondary objectives, such as implementing a multiplayer component in the form of a "Leader Board" and other envisioned mechanics, were not achieved due to time constraints and project organization.

---

### Internal Feedback:

- It was recommended to change the sound effect of the balloons popping and to change the musical theme on the home screen.

- The idea of enhancing the endearing aspect of the game to better align with the desired game feel was suggested.

- Aspects such as optimization and performance in the use of lighting and shadows were improved for minimal resource usage on mobile devices compared to the initial prototype.

---

### External Feedback:

- The game received positive feedback from players aged between 40 and 50 years old, with the most common opinion being that it is an entertaining and addictive game.

- The colorblind filter doesn't cover all spectrums of the disorder, so further research is required to meet the demands of players with such deficiencies in future updates.

---

## Conclusions:

"Poplloon" was a project that at the beginning of its creation seemed easy to accomplish; however, the implementation of accessibility components and memory optimization greatly hindered its development, mainly due to lack of preparation and knowledge.

The lessons learned will be applied to improve planning and risk management.

I am grateful for the advice of professionals known in my circle, who kindly helped me improve the game feel of the game, and to Pablo Vázquez Romualdo for contributing his advanced knowledge in data-oriented programming.

