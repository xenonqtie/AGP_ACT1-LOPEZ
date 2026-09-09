# AGP_ACT1-LOPEZ
Predicted distance for Cube B: 25 units

| Cube | 30 fps | 60 fps | 144 fps |
|------|--------|--------|---------|
| A    |  750   |  1500  |  3600   |
| B    |   25   |  25    |  25     |

Why Cube A's numbers change:
Cube A moves 5 units every frame without measuring time passed between frames. Since higher frame rates run Update() more often per second, Cube A takes many more steps, making its speed depend on frame rate rather than real time.

