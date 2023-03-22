﻿namespace LinqTesting
{
    public static class Shared
    {
        public static readonly int[] Array =
        {
            1, 2, 4, 5, 6, 6, 6, 7, 8, 12, 12, 13, 14, 15, 16, 16, 17, 17, 19, 20, 21, 22, 22, 24, 25, 25, 25, 27, 27,
            28, 28, 29, 30, 31, 32, 32, 34, 35, 35, 36, 39, 39, 42, 43, 43, 44, 45, 46, 48, 48, 49, 49, 50, 50, 51, 55,
            55, 56, 57, 58, 58, 61, 61, 61, 64, 65, 66, 66, 68, 69, 70, 71, 72, 73, 74, 75, 75, 76, 81, 82, 82, 83, 84,
            84, 85, 86, 87, 87, 88, 89, 95, 99, 101, 102, 103, 105, 110, 113, 114, 115, 119, 119, 120, 120,
            120, 122, 124, 125, 125, 125, 127, 127, 127, 128, 129, 129, 130, 134, 135, 136, 136, 138, 141, 142, 146,
            146, 147, 147, 148, 150, 150, 150, 152, 152, 153, 153, 157, 157, 159, 161, 161, 163, 164, 164, 166, 166,
            169, 169, 170, 170, 172, 172, 173, 174, 175, 176, 178, 181, 183, 183, 186, 186, 190, 190, 191, 192, 192,
            192, 193, 195, 195, 197, 197, 199, 199, 200, 201, 203, 204, 204, 204, 206, 206, 207, 209, 210, 210, 210,
            211, 211, 211, 212, 213, 213, 214, 215, 215, 216, 218, 219, 219, 222, 222, 223, 226, 228, 229, 229, 229,
            230, 230, 230, 231, 232, 232, 232, 233, 234, 235, 236, 236, 236, 236, 237, 238, 240, 240, 240, 241, 241,
            241, 242, 244, 245, 246, 248, 257, 258, 258, 260, 261, 262, 262, 263, 265, 266, 267, 268, 270, 271, 272,
            272, 273, 273, 274, 274, 274, 277, 277, 278, 279, 280, 282, 282, 282, 282, 282, 283, 283, 283, 285,
            286, 289, 289, 291, 291, 292, 293, 293, 294, 295, 297, 299, 300, 301, 301, 302, 303, 303, 304, 304, 306,
            306, 307, 307, 307, 308, 308, 308, 308, 310, 312, 312, 313, 313, 316, 317, 318, 319, 319, 319, 322, 322,
            322, 322, 324, 324, 325, 325, 328, 330, 330, 332, 332, 332, 332, 333, 334, 335, 339, 339, 340, 341, 341,
            343, 344, 345, 347, 348, 348, 348, 349, 350, 350, 351, 352, 356, 356, 357, 359, 360, 360, 363, 364, 364,
            365, 365, 369, 370, 371, 374, 375, 376, 377, 377, 380, 381, 382, 383, 385, 386, 386, 387, 387, 387, 387,
            389, 389, 389, 391, 392, 393, 394, 396, 397, 397, 398, 398, 399, 399, 401, 402, 404, 406, 407, 410, 411,
            413, 413, 415, 416, 417, 417, 417, 420, 421, 422, 423, 423, 423, 424, 424, 425, 425, 427, 431, 431, 432,
            433, 433, 433, 434, 434, 434, 435, 435, 435, 437, 438, 438, 438, 440, 440, 442, 443, 445, 446, 448, 448,
            450, 450, 450, 453, 455, 456, 456, 457, 460, 461, 462, 463, 464, 465, 466, 468, 469, 470, 471, 475, 475,
            476, 476, 477, 478, 479, 479, 480, 485, 486, 486, 487, 487, 487, 489, 490, 490, 491, 492, 492, 492, 494,
            495, 496, 496, 496, 496, 497, 500, 502, 504, 505, 508, 508, 508, 508, 509, 510, 511, 511, 513, 514, 515,
            516, 516, 517, 517, 517, 518, 518, 520, 521, 524, 524, 527, 529, 531, 532, 533, 533, 534, 537, 538,
            540, 540, 541, 542, 542, 543, 544, 544, 544, 545, 546, 547, 547, 548, 549, 550, 550, 551, 551, 552, 553,
            553, 556, 558, 559, 559, 559, 560, 561, 561, 561, 563, 566, 567, 567, 568, 569, 569, 571, 571, 574, 576,
            577, 577, 578, 578, 579, 579, 579, 580, 582, 582, 584, 584, 584, 585, 586, 587, 588, 588, 589, 590, 590,
            591, 592, 593, 596, 597, 597, 598, 599, 599, 600, 601, 602, 603, 604, 604, 605, 607, 609, 609, 610, 611,
            611, 612, 612, 613, 615, 615, 617, 619, 621, 621, 622, 623, 623, 624, 626, 626, 626, 627, 627, 629, 629,
            629, 630, 631, 632, 635, 635, 635, 637, 638, 638, 638, 639, 641, 643, 645, 645, 645, 647, 647, 650, 652,
            652, 652, 654, 655, 655, 657, 658, 660, 661, 662, 664, 666, 667, 669, 670, 671, 673, 674, 676, 677, 677,
            677, 679, 680, 683, 683, 683, 683, 684, 687, 689, 689, 690, 690, 690, 691, 692, 693, 695, 695, 700,
            700, 701, 701, 702, 706, 706, 706, 707, 710, 710, 710, 711, 712, 713, 713, 713, 715, 717, 718, 719, 721,
            722, 723, 724, 724, 725, 725, 725, 725, 726, 726, 726, 726, 727, 727, 727, 728, 728, 729, 729, 729, 732,
            733, 734, 734, 735, 735, 736, 737, 739, 739, 742, 742, 742, 742, 743, 745, 746, 746, 747, 748, 748, 748,
            749, 751, 752, 754, 755, 756, 757, 758, 759, 761, 763, 765, 766, 766, 767, 769, 769, 771, 772, 774, 774,
            774, 775, 775, 776, 777, 777, 779, 779, 780, 780, 781, 782, 782, 783, 784, 785, 786, 786, 787, 788, 788,
            789, 789, 789, 791, 792, 793, 793, 794, 795, 796, 796, 797, 798, 798, 799, 799, 799, 801, 801, 802, 803,
            803, 804, 804, 804, 805, 805, 806, 807, 807, 807, 808, 810, 810, 811, 812, 813, 813, 814, 815, 816, 816,
            817, 818, 819, 820, 821, 822, 822, 822, 824, 825, 826, 827, 830, 832, 833, 833, 835, 836, 837, 838, 840,
            840, 841, 842, 842, 843, 846, 848, 848, 850, 851, 852, 852, 853, 854, 855, 855, 856, 858, 861, 862, 863,
            863, 863, 863, 863, 866, 867, 868, 868, 869, 869, 871, 871, 872, 873, 873, 875, 879, 879, 880, 882, 882,
            883, 883, 883, 884, 885, 885, 886, 886, 886, 890, 890, 892, 893, 894, 895, 895, 895, 898, 898, 901, 902,
            902, 902, 903, 904, 904, 908, 908, 909, 911, 912, 914, 917, 918, 920, 923, 925, 926, 928, 929, 930,
            931, 935, 935, 935, 939, 941, 941, 942, 943, 945, 946, 947, 947, 947, 947, 948, 949, 949, 952, 954, 954,
            955, 956, 957, 960, 961, 961, 963, 965, 965, 965, 965, 966, 968, 969, 969, 970, 970, 972, 976, 977, 977,
            978, 980, 980, 981, 983, 983, 984, 986, 986, 986, 987, 989, 989, 993, 995, 996, 997, 998
        };

        public static readonly int Search = 987;
    }
}