.nds
.relativeinclude on
.erroronwarning on

; Abre a ROM de 64MB
.open "..\..\Nova_Rom\cdos_ptbr.nds", 0x00000000

; Inserindo arquivos de avatares.
.org 0x001F8050
.incbin "..\..\Patches\DawnDignity\overlay\0x1F8050 - Soma face.bin"

.org 0x010F0000
.incbin "..\..\Patches\DawnDignity\data\sc\f_com01.dat"

.org 0x011D6000
.incbin "..\..\Patches\DawnDignity\data\sc\f_farik0.dat"

.org 0x011D8000
.incbin "..\..\Patches\DawnDignity\data\sc\f_farik1.dat"

.org 0x011DA000
.incbin "..\..\Patches\DawnDignity\data\sc\f_farik2.dat"

.org 0x011E4000
.incbin "..\..\Patches\DawnDignity\data\sc\f_fdari0.dat"

.org 0x011E6000
.incbin "..\..\Patches\DawnDignity\data\sc\f_fdari1.dat"

.org 0x011E8000
.incbin "..\..\Patches\DawnDignity\data\sc\f_fdari2.dat"

.org 0x011EA000
.incbin "..\..\Patches\DawnDignity\data\sc\f_fdari3.dat"

.org 0x011EC000
.incbin "..\..\Patches\DawnDignity\data\sc\f_fdomi0.dat"

.org 0x011EE000
.incbin "..\..\Patches\DawnDignity\data\sc\f_fdomi1.dat"

.org 0x011F0000
.incbin "..\..\Patches\DawnDignity\data\sc\f_fdomi2.dat"

.org 0x011F2000
.incbin "..\..\Patches\DawnDignity\data\sc\f_fdomi3.dat"

.org 0x01200000
.incbin "..\..\Patches\DawnDignity\data\sc\f_fhume0.dat"

.org 0x01202000
.incbin "..\..\Patches\DawnDignity\data\sc\f_fhume1.dat"

.org 0x01204000
.incbin "..\..\Patches\DawnDignity\data\sc\f_fhume2.dat"

.org 0x0120A000
.incbin "..\..\Patches\DawnDignity\data\sc\f_fjuli0.dat"

.org 0x0120C000
.incbin "..\..\Patches\DawnDignity\data\sc\f_fjuli1.dat"

.org 0x0120E000
.incbin "..\..\Patches\DawnDignity\data\sc\f_fjuli2.dat"

.org 0x01222000
.incbin "..\..\Patches\DawnDignity\data\sc\f_fmina0.dat"

.org 0x01224000
.incbin "..\..\Patches\DawnDignity\data\sc\f_fmina1.dat"

.org 0x01226000
.incbin "..\..\Patches\DawnDignity\data\sc\f_fmina2.dat"

.org 0x01228000
.incbin "..\..\Patches\DawnDignity\data\sc\f_fmina3.dat"

.org 0x0122A000
.incbin "..\..\Patches\DawnDignity\data\sc\f_fmina4.dat"

.org 0x0122C000
.incbin "..\..\Patches\DawnDignity\data\sc\f_fmina5.dat"

.org 0x01232000
.incbin "..\..\Patches\DawnDignity\data\sc\f_fseri0.dat"

.org 0x01234000
.incbin "..\..\Patches\DawnDignity\data\sc\f_fseri1.dat"

.org 0x01236000
.incbin "..\..\Patches\DawnDignity\data\sc\f_fseri2.dat"

.org 0x01238000
.incbin "..\..\Patches\DawnDignity\data\sc\f_fseri3.dat"

.org 0x0123A000
.incbin "..\..\Patches\DawnDignity\data\sc\f_fsoma0.dat"

.org 0x0123C000
.incbin "..\..\Patches\DawnDignity\data\sc\f_fsoma1.dat"

.org 0x0123E000
.incbin "..\..\Patches\DawnDignity\data\sc\f_fsoma2.dat"

.org 0x01240000
.incbin "..\..\Patches\DawnDignity\data\sc\f_fsoma3.dat"

.org 0x01242000
.incbin "..\..\Patches\DawnDignity\data\sc\f_fsoma4.dat"

.org 0x01244000
.incbin "..\..\Patches\DawnDignity\data\sc\f_fsoma5.dat"

.org 0x01246000
.incbin "..\..\Patches\DawnDignity\data\sc\f_fsoma6.dat"

.org 0x01248000
.incbin "..\..\Patches\DawnDignity\data\sc\f_fsoma7.dat"

.org 0x0124A000
.incbin "..\..\Patches\DawnDignity\data\sc\f_fsoma8.dat"

.org 0x0124E000
.incbin "..\..\Patches\DawnDignity\data\sc\f_fyoko0.dat"

.org 0x01250000
.incbin "..\..\Patches\DawnDignity\data\sc\f_fyoko1.dat"

.org 0x01252000
.incbin "..\..\Patches\DawnDignity\data\sc\f_fyoko2.dat"

.org 0x01254000
.incbin "..\..\Patches\DawnDignity\data\sc\f_fyoko3.dat"

.org 0x01256000
.incbin "..\..\Patches\DawnDignity\data\sc\f_fyoko4.dat"

.org 0x0130A000
.incbin "..\..\Patches\DawnDignity\data\sc\f_kaisou6.dat"

; Fecha a ROM
.close