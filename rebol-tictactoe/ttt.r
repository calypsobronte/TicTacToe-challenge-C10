ttt: func [f] [
  f/text: either turn: not turn ["X"]["O"]  show f
  lay: copy "" repeat i 9 [do rejoin ["append lay b" i "/text"]]
  xxx: [{xxx??????}{???xxx???}{??????xxx}{x??x??x}{??x?x?x??}{x???x???x}]
  foreach i xxx [if find/any lay i [alert "X is the winner."]]
  ooo: [{ooo??????}{???ooo???}{??????ooo}{o??o??o}{??o?o?o??}{o???o???o}]
  foreach i ooo [if find/any lay i [alert "O is the winner."]]
] turn: false

_close: func [f] [
  f: quit
]

view center-face layout [
  backcolor white
  style b button 100x100 effect [gradient 1x1 0.200.100 0.0.100] font-size 60 " " [ttt face]
  b1: b b2: b b3: b
  return
  b4: b b5: b b6: b
  return
  b7: b b8: b b9: b
  return
  style c button 100x50 effect [gradient 1x1 200.0.0 0.0.100] font-size 30 "Close" [_close face]
  c1: c
]