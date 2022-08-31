# CustomInventories
Synapse plugin for game SCP:SL (SCP Secret Laboratory) that allows host to customize starting inventories of players with addition of setting chances of multiple items on one slot.

## Explanation

Example:

```
inventory:
-
# Affected Class
  classID: 1
  # Slots
  slotList:
  - itemID: 2
    chance: 100
    index: 0
  - itemID: 1
    chance: 100
    index: 0
```

What this code does? Every Class D has 100% chance of obtaining Research coordinator keycard that afterwards has again a 100% chance to be swapped for Scientist keycard. Everything on slot one ( index = 0 because in programming lists and arrays start from index 0 but in game it's slot 1 )

## Config

### IMPORTANT
- Plugin will delete default inventories of classes so you need to configure them yourself
- Add items in order eg. first for index 0 then index 1 etc.

```
- itemID: 2
    chance: 100
    index: 0
  - itemID: 15
    chance: 20
    index: 0
  - itemID: 5
    chance: 30
    index: 1
  - itemID: 4
    chance: 20
    index: 2
```

And not

```
- itemID: 2
    chance: 100
    index: 5
  - itemID: 15
    chance: 20
    index: 3
  - itemID: 5
    chance: 30
    index: 3
  - itemID: 4
    chance: 20
    index: 2
```


To add another item just copy this

```
- itemID: -1
    chance: 100
    index: 0
```

and add to the ```slotlist```

To add inventory for another class just copy the whole thing

```
-
# Affected Class
  classID: -1
  # Slots
  slotList:
  - itemID: -1
    chance: 100
    index: 0
```

Yes, without word ```inventory```

## Credits
- Idea and chunk of code from [AlmigtyLks](https://github.com/AlmightyLks-SCP/CustomLoadout), added ability to give multiple items on the same slot
