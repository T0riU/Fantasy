# Fantasy — Creature Battle Simulator

A C# WinForms application for managing and simulating combat between fantasy creatures. Creatures are defined through a class hierarchy with unique abilities, stored as JSON, and interacted with through a GUI.

---

## Project Structure

```
Fantasy.sln
Fantasy/
  Creature.cs         Abstract base class — stats, combat, damage
  Creatures.cs        Container holding all creature lists
  Player.cs           Player character
  Lizard.cs           Abstract — Regen ability
  Draconian.cs        Abstract (Lizard) — FireAttack
  Fairy.cs            Abstract — NatureMagic ability
  Elf.cs              Abstract (Fairy) — RegenByMagic ability
  Undead.cs           Abstract — BlockAllDamage ability
  Dragon.cs           (Draconian) — StrongBite
  Hydra.cs            (Lizard) — multi-head scaling attacks
  Wyvern.cs           (Draconian) — AirAttack
  Ghost.cs            (Undead) — Scream
  Skeleton.cs         (Undead) — SwordAttack
  Gnome.cs            (Fairy) — resistance stat buffs
  Ent.cs              (Fairy) — BranchAttack
  HighElf.cs          (Elf) — escalating ComboAttack
  DarkElf.cs          (Elf) — MagicSword
  Orc.cs              (Elf) — PlayDead damage reduction
  Theme.cs            Three switchable UI color themes
  MainForm.cs         Main window
  ChangeForm.cs       Add / edit / delete creature dialog
  Info.cs             About dialog with GitHub link and Readme.pdf
  Readme.pdf          Original task specification
```

---

## Creature Hierarchy

```
Creature
├── Player
├── Fairy
│   ├── Gnome
│   ├── Ent
│   └── Elf
│       ├── HighElf
│       ├── DarkElf
│       └── Orc
├── Lizard
│   ├── Hydra
│   └── Draconian
│       ├── Dragon
│       └── Wyvern
└── Undead
    ├── Ghost
    └── Skeleton
```

---

## Stats

Every creature has: HP, Mana, Power, ManaUsage, Resistance (physical, capped at 100%), MagicResistance (capped at 100%). All values are clamped between 1 and 1000 (MAXSTAT).

---

## Combat

Three attack types: Physical (damage reduced by Resistance), Magic (costs mana, reduced by MagicResistance), PhysicalAndMagic (both components combined). On death the creature resets to full stats and the kill/death counters update.

---

## Unique Abilities

| Creature | Ability | Effect |
|----------|---------|--------|
| Player | PhysicalAttack, MagicAttack, ManaRegen | Standard attacks + mana restore |
| Dragon | StrongBite | Physical ×1.5 Power |
| Wyvern | AirAttack | Magic attack (Power + 12) |
| Hydra | HeadsXAttack | Physical damage scales with number of deaths; HP cap grows over time |
| Ghost | Scream | Magic ×1.1 Power |
| Skeleton | SwordAttack | Physical ×1.3 Power |
| Gnome | PhysicalResStatUp / MagicResStatUp | +5 resistance per use, max 80 |
| Ent | BranchAttack | Physical + Magic combined |
| HighElf | ComboAttack | Magic, damage multiplies with each consecutive combo use |
| DarkElf | MagicSword | Magic ×1.3 Power |
| Orc | PlayDead | Next hit taken is reduced by 80% |
| Undead (all) | BlockAllDamage | Toggle 100% resistance to both damage types |

---

## UI

Main window — player HP/Mana display, creature list (DataGridView), ability dropdowns for both player and selected creature, buttons to use abilities, edit, or add creatures.

ChangeForm — add a new creature (choose race from dropdown, fill stats) or edit/delete an existing one.

Theme — three color themes switchable at runtime via the menu button; selection is persisted in user settings.

Save — on close the app prompts to save the creature list to a JSON file. The file path is also configurable via the Open File menu.

---

## Dependencies

| Package | Purpose |
|---------|---------|
| Newtonsoft.Json | Serialize / deserialize creature data to JSON |
