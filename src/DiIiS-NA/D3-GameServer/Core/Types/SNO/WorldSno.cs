﻿using System;
using System.Linq;

namespace DiIiS_NA.D3_GameServer.Core.Types.SNO
{
    public enum WorldSno: int
    {
		__NONE = -1,
		a2c2dun_zolt_treasurehunter = 2812,
		trdun_leoric_level01 = 2826,
		a1trdun_level01 = 50579,
		a1trdun_level04 = 50582,
		a1trdun_level06 = 50584,
		a1trdun_level07 = 50585,
		a2c1dun_swr_caldeum_01 = 50588,
		a2c2dun_cave_random01 = 50589,
		a2dun_zolt_sw_random01 = 50594,
		a2dun_zolt_timed01_level01 = 50596,
		a2dun_zolt_level01 = 50610,
		a2dun_zolt_level02 = 50611,
		a2dun_zolt_level03 = 50612,
		a2dun_zolt_lobby = 50613,
		axe_bad_data = 50623,
		axe_flatworld = 50627,
		caout_interior_d = 50657,
		caout_mine_abandoned_cellara = 50658,
		pvp_map2 = 50715,
		pvp_maze_arena_01 = 50716,
		pvp_octagon_arena_01 = 50717,
		pvp_pillar_01 = 50718,
		pvp_stairs_arena_01 = 50719,
		tod_loadscreen = 50814,
		caout_interior_f = 51270,
		a2c3dun_aqd_oasis_level01 = 57491,
		a1c6_spidercave_01 = 58231,
		a2dun_swr_adria_level01 = 58493,
		trdun_leoric_level02 = 58982,
		trdun_leoric_level03 = 58983,
		a2dun_aqd_special_01 = 59486,
		a2dun_zolt_bossfight_level04 = 60193,
		trdun_cave_nephalem_01 = 60393,
		trdun_cave_nephalem_02 = 60394,
		trdun_cave_nephalem_03 = 60395,
		caout_khamsin_mine = 60432,
		trdun_crypt_skeletonkingcrown_01 = 60600,
		trdun_cain_intro = 60713,
		a2_belial_room_01 = 60756,
		caout_interior_g_stranded2 = 60838,
		a2dun_zolt_head_random01 = 61631,
		a2trdun_cave_oasis_random01 = 62568,
		a2trdun_cave_oasis_random02 = 62569,
		trout_sub240_fields_cellara = 62706,
		trout_adriascellar = 62751,
		a2dun_aqd_special_a = 62776,
		a2dun_aqd_special_b = 62779,
		caout_town = 70885,
		trout_town = 71150,
		trdun_crypt_falsepassage_01 = 72636,
		trdun_crypt_falsepassage_02 = 72637,
		trout_townattack = 72882,
		a1trdun_king_level08 = 73261,
		a1dun_leor_manor = 75049,
		a3dun_keep_level04 = 75434,
		trdun_butcherslair_02 = 78839,
		pvp_caout_arena_01 = 79100,
		a3dun_crater_st_level01 = 79401,
		a1trdun_cath_tower_of_power = 80057,
		a2dun_zolt_shadowrealm_level01 = 80589,
		trout_oldtistram_cellar = 80730,
		a3dun_crater_st_level02 = 80763,
		a3dun_rmpt_level01 = 81019,
		a3dun_crater_level_01 = 81049,
		a1_cave_fields_scavengerden_level01 = 81163,
		a1_cave_fields_scavengerden_level02 = 81164,
		a2_belial_room_intro = 81715,
		a3dun_crater_level_02 = 81934,
		highlands_randomdrlg_westtower_level01 = 82076,
		highlands_randomdrlg_westtower_level02 = 82313,
		a1_cave_fields_minecavea_level01 = 82370,
		a1_cave_fields_minecavea_level02 = 82371,
		a1_cave_highlands_goatcavea_level01 = 82502,
		a1_cave_highlands_goatcavea_level02 = 82511,
		trout_oldtristram_treecave = 84518,
		a3dun_crater_st_level04 = 85201,
		a2dun_cald = 86594,
		trout_tristram_leahsroom = 86856,
		trout_highlands_dunexteriora = 87707,
		trdun_crypt_skeletonkingcrown_02 = 92126,
		a3dun_rmpt_level02 = 93099,
		a3dun_keep_level03 = 93104,
		trdun_jail_level01 = 94676,
		a3_battlefields_02 = 95804,
		pvp_butcher_arena_01 = 102100,
		trdun_crypt_fields_flooded_memories_level01 = 102299,
		gluttony_boss = 103209,
		a4dun_garden3_spireentrance = 103910,
		trout_vendor_tinker = 104446,
		a1trdun_level05_templar = 105406,
		trout_oldtistram_cellar_1 = 106746,
		trout_oldtistram_cellar_2 = 106752,
		trout_oldtistram_cellar_3 = 107050,
		trout_fields_vendor_curios = 107445,
		a4dun_heaven_1000_monsters_fight = 109143,
		trout_tristram_inn = 109362,
		a4dun_garden_of_hope_01 = 109513,
		a4dun_hell_portal_01 = 109525,
		a4dun_hell_portal_02 = 109530,
		a4dun_diablo_arena = 109561,
		a2dun_cald_uprising = 109894,
		a2dun_portalroulette_a = 111376,
		a2dun_boneyard_worm_cave_01 = 111666,
		a2trdun_boneyard_spider_cave_01 = 111670,
		pvp_cald_swr_ver2 = 112864,
		a1trdun_tyrael_level09 = 117405,
		a3dun_crater_level_03 = 119290,
		a3dun_crater_st_level01b = 119641,
		a3dun_crater_st_level04b = 119650,
		fields_cave_swordofjustice_level01 = 119888,
		a3dun_azmodan_arena = 121214,
		a4dun_spire_level_01 = 121579,
		a2dun_zolt_blood02 = 123183,
		pvp_neph_arena = 129123,
		a4dun_spire_level_02 = 129305,
		a4dun_spire_level_03 = 129306,
		trout_tristram_cainshouse = 130161,
		pvp_crypt_arena_01 = 131908,
		a1_cave_highlands_vendorrescue = 132995,
		caout_oasis_cellar_d_refugeecellar = 134820,
		caout_oasis_cellar_c_zakarwamerchant = 134822,
		a1_cave_wilderness_den_level01 = 135193,
		a1dun_labyrinth_01 = 135713,
		caout_stingingwinds_randomcellar_1 = 136058,
		caout_stingingwinds_randomcellar_2 = 136116,
		caout_stingingwinds_randomcellar_3 = 136136,
		a3dun_keep_level05 = 136415,
		trout_oldtristram_cellar_f = 136441,
		caout_oasis_randomcellar_1 = 136900,
		caout_oasis_randomcellar_2 = 136932,
		caout_oasis_randomcellar_3 = 136936,
		pvp_zolt_ruins_arena = 137439,
		a3dun_crater_st_level02b = 139272,
		pvp_crypt_arena_02 = 139469,
		a4dun_sigil_a = 139965,
		a3dun_bridge_interior_random01 = 140444,
		pvp_craterst_arena = 140638,
		a2_event_dyingman_mine = 140652,
		a4dun_sigil_b = 140709,
		a2dun_swr_swr_to_oasis_level01 = 146619,
		battlenet_mainscreen = 148534,
		caout_alcarnus_randomcellar_1 = 148899,
		caout_alcarnus_randomcellar_2 = 148907,
		caout_alcarnus_randomcellar_3 = 148908,
		limbo = 149898,
		a4dun_diablo_shadowrealm_01 = 153670,
		trdun_crypt_skeletonkingcrown_00 = 154587,
		a2dun_aqd_oasis_randomfacepuzzle_small = 157882,
		a2dun_aqd_oasis_randomfacepuzzle_large = 158593,
		a2trdun_cave_oasis_random02_level02 = 161011,
		caout_refugeecamp = 161472,
		a1trdun_cave_old_ruins_random01 = 161961,
		caout_oasis_randomcellar_4 = 162790,
		trdun_crypt_fields_flooded_memories_level02 = 165797,
		a4dun_libraryoffate = 166640,
		trout_townattack_chapelcellar_a = 167721,
		a2dun_zolt_timed01_level02 = 168196,
		pvp_trainingground = 168230,
		a2dun_cave_mapdungeon_level01 = 169477,
		pvp_traininginn = 170375,
		trout_highlands_servanthouse_cellar_vendor = 171189,
		a3dun_hub_keep = 172909,
		a2_swr_fcauseway_01 = 174434,
		trout_tristram_cainshouse_event = 174449,
		a3dun_keep_random_01 = 174516,
		caout_hub_inn = 174530,
		a3dun_keep_random_02 = 174555,
		a3dun_keep_random_03 = 174560,
		a3dun_keep_random_04 = 174665,
		a4dun_heaven_hub_keep = 178152,
		a4dun_sigil_d = 180517,
		a1dun_spidercave_01 = 180550,
		a4dun_sigil_c = 181644,
		a3dun_keep_hub_inn = 182875,
		a4dun_heaven_1000_monsters_fight_entrance = 182944,
		a1dun_spidercave_02 = 182976,
		a4dun_heaven_keep_hub_inn = 183800,
		a3dun_keep_random_cellar_01 = 185217,
		a3dun_keep_random_cellar_02 = 185247,
		a3dun_hub_adria_tower = 186552,
		a3dun_icecaves_random_01 = 189259,
		a3dun_icecaves_timed_01 = 189910,
		battlenet_act2screen = 191376,
		battlenet_act3screen = 191389,
		battlenet_act4screen = 191390,
		a2dun_aqd_oasis_level01 = 192640,
		a2dun_aqd_oasis_level00 = 192687,
		a1_cave_wilderness_den_level02 = 194231,
		a2dun_cave_mapdungeon_level02 = 194238,
		a2trdun_cave_oasis_random01_level02 = 194240,
		battlenet_pvpscreen = 194282,
		caout_cellar_alcarnus_main = 195200,
		a2_event_priceofmercy_cellar = 195997,
		a2dun_zolt_random_portalroulette_02 = 196036,
		a2_rockworm_cellar_cave = 196222,
		a4dun_diablo_arena_phase3 = 196292,
		a3dun_keep_random_cellar_03 = 197622,
		a4dun_spire_level_00 = 198281,
		trout_wilderness_corpsehouse = 199388,
		a2dun_cave_bloodvial_01 = 204628,
		a2dun_cave_bloodvial_02 = 204674,
		a3dun_hub_adria_tower_intro = 204707,
		a4dun_spire_diabloentrance = 205399,
		a3dun_bridge_interior_random02 = 205422,
		a4dun_spire_level_04 = 210725,
		a1dun_random_level01 = 211471,
		a4dun_spire_exterior = 214956,
		a2trdun_boneyard_spider_cave_02 = 218967,
		a2dun_boneyard_worm_cave_02 = 218970,
		a4dun_garden_of_hope_random = 219659,
		a2c2dun_cave_random01_level02 = 220804,
		a3dun_icecaves_random_01_level_02 = 221688,
		a3dun_icecaves_timed_01_level_02 = 221689,
		a3dun_keep_random_01_level_02 = 221748,
		a3dun_keep_random_02_level_02 = 221749,
		a3dun_keep_random_03_level_02 = 221750,
		a3dun_keep_random_04_level_02 = 221751,
		a2dun_zolt_sw_random01_level02 = 222575,
		a1dun_crypt_dev_hell = 222591,
		utility_server_world = 223474,
		pvp_keep_arena = 225850,
		a3_battlefields_03 = 226713,
		pvp_garden_arena = 227206,
		a1trdun_cave_qa_well = 230288,
		x1_bogcave_random01 = 234962,
		pvp_leoricsgarden_arena = 235229,
		x1_bogcave_random02 = 235882,
		pvp_zolt_small_arena = 236154,
		battlenet_act1screen = 238775,
		x1_pof_dungeonlayout_level_01 = 245391,
		x1_pof_dungeonlayout_level_02 = 245402,
		x1_test_challengetestworld = 245736,
		x1_westm_int_gen_c_miser = 246369,
		x1_pof_dungeonboss_01 = 252144,
		qa_pvp_test_map = 252723,
		uber_bossworld1 = 256111,
		uber_bossworld2 = 256112,
		uber_bossworld3 = 256607,
		uber_portalworld = 257117,
		pvp_regicide_prototype_small = 258624,
		x1_westm_zone_01 = 261712,
		x1_westm_zone_03 = 263494,
		flatworld_pvp_demo = 265834,
		x1_bog_01 = 267412,
		x1_bog_bogpeople_cellar_c = 269874,
		x1_fortress_level_01 = 271233,
		x1_fortress_level_02 = 271235,
		x1_bog_bogpeople_cellar_d = 271533,
		x1_bog_bogpeople_cellar_a = 272172,
		pvp_duel_box = 273257,
		x1_fortress_temp_malthaelarena = 273433,
		pvp_field_test = 273769,
		pvp_z_lane_test = 274044,
		pvp_peanut_longlane = 274658,
		pvp_duel_small = 275192,
		x1_pand_ext_level_01 = 275415,
		x1_lr_tileset_cath = 275921,
		x1_lr_tileset_corruptspire = 275926,
		x1_lr_tileset_leorics = 275930,
		x1_lr_tileset_rootcave = 275943,
		x1_lr_tileset_wormcaves = 275944,
		x1_lr_tileset_zoltarchives = 275945,
		x1_lr_tileset_crypt = 275946,
		x1_lr_tileset_floodedcave = 275947,
		x1_lr_tileset_icecave = 275960,
		x1_lr_hubworld = 276032,
		pvp_three_control = 276095,
		pvp_murderball_test_01 = 277669,
		pvp_duel_small_multi = 279626,
		x1_bog_adriaritual = 282460,
		x1_catacombs_level01 = 283552,
		x1_catacombs_level02 = 283566,
		x1_westm_rescueinterior_01 = 284491,
		x1_westm_rescueinterior_02 = 284492,
		battlenet_act5screen = 288104,
		x1_lr_level_01 = 288454,
		x1_lr_level_02 = 288685,
		x1_lr_level_03 = 288687,
		x1_lr_level_04 = 288798,
		x1_lr_level_05 = 288800,
		x1_lr_level_06 = 288802,
		x1_lr_level_07 = 288804,
		x1_lr_level_08 = 288810,
		x1_lr_level_09 = 288814,
		x1_lr_level_10 = 288816,
		x1_lr_tileset_zoltruins = 288823,
		x1_lr_tileset_sewers = 288843,
		x1_westm_int_gen_a_01 = 288972,
		x1_westm_custom_alley_01_rat = 289523,
		x1_pand_ext_gateoverlook = 291941,
		x1_pand_hexmaze = 294585,
		x1_westm_int_rescue_guards_01 = 294633,
		x1_pand_batteringram = 295225,
		x1_adria_boss_arena_02 = 297771,
		x1_pand_hexmaze_en_01 = 302603,
		x1_westm_int_gen_b_01madman = 302733,
		x1_westm_int_gen_a_01zombiesorcerer = 302876,
		x1_westm_int_gen_b_02doomedwoman = 303058,
		x1_westm_int_gen_a02necromancer = 303361,
		x1_westm_scoundrelevent = 303430,
		x1_westmarch_hub = 304235,
		x1_westm_alley_rats = 304358,
		x1_westm_intro = 306549,
		x1_pand_hexmaze_2 = 306747,
		x1_westm_int_rescue_guards_02 = 306915,
		x1_urzael_arena = 308446,
		x1_westmarch_cath_int = 308549,
		x1_westmarch_overlook_d = 308705,
		x1_pand_hexmaze_en_02 = 310706,
		x1_westm_reformedcultist = 310845,
		pvp_square_test_01 = 315043,
		x1_westm_int_gen_a_01_captainstokely = 321968,
		x1_pand_ext_cellar_a = 322531,
		x1_lr_tileset_keep_war = 322661,
		x1_lr_tileset_keep_forge = 322662,
		x1_lr_tileset_keep_river = 322663,
		x1_lr_tileset_aqueducts = 322710,
		x1_lr_tileset_spidercaves = 322726,
		x1_lr_tileset_crater = 323565,
		x1_lr_tileset_cath_large = 324418,
		x1_lr_tileset_cath_small = 324425,
		x1_lr_tileset_leorics_small = 327401,
		x1_lr_tileset_crypt_small = 327768,
		x1_lr_tileset_zoltarchives_small = 327864,
		x1_lr_tileset_cath_extralarge = 328037,
		x1_westm_int_gen_c_01_skeleton_rush = 328325,
		x1_westm_int_gen_b_02_var_c_yard_rush = 328344,
		x1_malthael_boss_arena = 328484,
		x1_westm_int_gen_c_03_elements = 328933,
		x1_westm_int_gen_b_03_var_c_panic = 330207,
		x1_westm_templar_event = 330391,
		x1_lr_tileset_exterior_tristramfields = 330465,
		x1_westm_cellar_corpsefinder = 330761,
		x1_lr_tileset_westmarch = 331263,
		x1_lr_tileset_abattoir = 331384,
		x1_lr_tileset_bogcave = 331385,
		x1_lr_tileset_fortress = 331387,
		x1_lr_tileset_catacombs = 331388,
		x1_lr_tileset_hexmaze = 331389,
		x1_a5_challenge_westm_dreadghosts = 331944,
		x1_lr_tileset_exterior_bog = 332284,
		x1_tristram_adventure_mode_hub = 332336,
		x1_lr_tileset_aqueducts_small = 333443,
		x1_westm_int_gen_b_03_var_b_ghostchase = 335058,
		x1_lr_tileset_aqueducts_large = 335192,
		x1_lr_tileset_corruptspire_large = 335410,
		x1_lr_tileset_crypt_large = 335922,
		x1_lr_tileset_crater_small = 335992,
		x1_lr_tileset_floodedcave_large = 336064,
		x1_lr_tileset_icecave_large = 336068,
		x1_lr_tileset_keep_forge_large = 336073,
		x1_lr_tileset_keep_river_large = 336077,
		x1_lr_tileset_keep_war_large = 336078,
		x1_lr_tileset_leorics_large = 336083,
		x1_lr_tileset_rootcave_large = 336085,
		x1_lr_tileset_sewers_large = 336086,
		x1_lr_tileset_spidercaves_large = 336096,
		x1_lr_tileset_wormcaves_large = 336104,
		x1_lr_tileset_zoltarchives_large = 336137,
		x1_lr_tileset_zoltruins_large = 336139,
		x1_lr_tileset_corruptspire_small = 336143,
		x1_lr_tileset_floodedcave_small = 336148,
		x1_lr_tileset_icecave_small = 336149,
		x1_lr_tileset_keep_forge_small = 336234,
		x1_lr_tileset_keep_river_small = 336239,
		x1_lr_tileset_keep_war_small = 336240,
		x1_lr_tileset_rootcave_small = 336242,
		x1_lr_tileset_sewers_small = 336244,
		x1_lr_tileset_spidercaves_small = 336246,
		x1_bogcave_random01_b = 336572,
		x1_bogcave_random02_b = 336573,
		x1_westm_int_gen_a_03_kingevent01 = 336844,
		x1_westm_int_gen_b_02_kingevent02 = 336852,
		x1_westm_int_gen_a_04_kingevent03 = 336902,
		x1_lr_tileset_wormcaves_small = 337001,
		x1_lr_tileset_zoltruins_small = 337003,
		x1_pand_ext_2_battlefields = 338600,
		x1_westm_deathorb_gideonscourt = 338891,
		x1_abattoir_random01 = 338930,
		x1_westm_graveyard_deathorb = 338944,
		x1_abattoir_random01_b = 338968,
		x1_abattoir_random02 = 338976,
		x1_abattoir_random02_b = 338977,
		x1_westm_deathorb_kerwinsrow = 339151,
		x1_heaven_pandemonium_portal = 339160,
		x1_pand_ext_batteringram_entrance_a = 339254,
		x1_westm_scoundrelevent_level02 = 340624,
		x1_catacombs_fakeentrance_02 = 341037,
		x1_catacombs_fakeentrance_03 = 341038,
		x1_catacombs_fakeentrance_04 = 341040,
		x1_catacombs_jeweler_1 = 342109,
		x1_lr_tileset_pony = 343942,
		x1_lr_tileset_pony_large = 343943,
		x1_lr_tileset_pony_small = 343944,
		x1_fortress_malthael_entrance = 346410,
		x1_lr_tileset_exterior_wilderness = 346912,
		x1_lr_tileset_exterior_highlands = 347368,
		x1_lr_tileset_exterior_gardensofhope1 = 347749,
		x1_lr_tileset_exterior_gardensofhope2 = 347750,
		x1_lr_tileset_exterior_gardensofhope3 = 347751,
		x1_lr_tileset_exterior_graveyard = 347861,
		x1_lr_tileset_exterior_pandext = 347903,
		x1_lr_tileset_breakup_wortham = 348606,
		x1_lr_tileset_exterior_boneyards = 349173,
		x1_lr_tileset_cratertowers1_small = 350309,
		x1_lr_tileset_cratertowers2_small = 350310,
		x1_lr_tileset_cratertowers3_small = 350311,
		x1_lr_tileset_cratertowers4_small = 350312,
		x1_lr_tileset_cratertowers5_small = 350313,
		x1_lr_tileset_cratertowers6_small = 350314,
		x1_lr_tileset_cratertowers7_small = 350315,
		x1_lr_tileset_exterior_ramparts1 = 351261,
		x1_lr_tileset_exterior_ramparts2 = 351269,
		x1_lr_tileset_exterior_ramparts3 = 351270,
		x1_lr_tileset_exterior_rampartsdamaged1 = 351271,
		x1_lr_tileset_exterior_rampartsdamaged2 = 351272,
		x1_lr_tileset_exterior_rampartsdamaged3 = 351273,
		x1_westm_cellar_kids = 351793,
		x1_westm_cellar_ruffians = 351794,
		x1_westm_int_gen_c_03_dogs = 357501,
		x1_westm_int_gen_c_03_deathmaiden = 357502,
		x1_pand_ext_cellar_b = 357650,
		x1_pand_ext_cellar_c = 357653,
		x1_pand_ext_cellar_d = 357656,
		x1_pand_ext_cellar_e = 357658,
		x1_catacombs_jeweler_2 = 358554,
		x1_westm_int_gen_c_01_zombiefireplace = 358641,
		x1_bogcave_random_connector = 358955,
		x1_bog_bogpeople_cellar_b = 359862,
		x1_lr_tileset_hexmaze_large = 360736,
		x1_lr_tileset_hexmaze_small = 360737,
		x1_lr_tileset_catacombs_large = 360756,
		x1_lr_tileset_catacombs_small = 360757,
		x1_lr_tileset_bogcave_large = 360768,
		x1_lr_tileset_bogcave_small = 360769,
		x1_lr_tileset_fortress_small = 360796,
		x1_lr_tileset_fortress_large = 360797,
		x1_lr_tileset_abattoir_large = 360811,
		x1_lr_tileset_abattoir_small = 360812,
		x1_lr_tileset_westmarch_small = 360815,
		x1_lr_tileset_westmarch_large = 360816,
		x1_lr_tileset_westmarchfire = 360823,
		x1_lr_tileset_westmarchfire_small = 360835,
		x1_lr_tileset_westmarchfire_large = 360836,
		x1_lr_tileset_fortressislands = 362155,
		x1_lr_tileset_fortressislands_small = 362175,
		x1_lr_tileset_hellportala_small = 362178,
		x1_lr_tileset_hellportalb_small = 362187,
		x1_lr_tileset_exterior_graveyard_small = 363977,
		x1_lr_tileset_exterior_bog_small = 363998,
		x1_lr_tileset_exterior_pandext_small = 364270,
		x1_lr_tileset_exterior_pandext_large = 364271,
		x1_lr_tileset_exterior_graveyard_large = 364391,
		x1_lr_tileset_exterior_bog_large = 364392,
		x1_lr_tileset_exterior_boneyards_large = 364533,
		a4dun_uber_diablo_shadowrealm_01 = 365973,
		x1_lr_tileset_event_crypt_udderchaos = 366326,
		x1_westm_int_blacksmith = 368426,
		x1_lr_tileset_crypt_small_udderchaos = 373812,
		x1_pand_hexmaze_bloone = 374758,
		x1_pand_hexmaze_borgoth = 374762,
		x1_pand_hexmaze_grotescor = 374766,
		x1_pand_hexmaze_haziael = 374770,
		x1_pand_hexmaze_magrethar = 374774,
		x1_pand_hexmaze_severag = 374778,
		x2_zpvp_cath_01 = 378972,
		p1_tgoblin_realm = 379962,
		p1_tgoblin_realm_bossroom = 380753,
		p2_scoundrelevent = 384425,
		p1_lr_tileset_cesspools_small = 389322,
		p1_lr_tileset_cesspools_large = 389323,
		p2_datedungeon_01 = 404654,
		p2_datedungeon_02 = 405005,
		p1_tieredrift_challenge = 405684,
		x1_p4_forest_coast_01 = 408254,
		a4dun_corruptspire_sidedungeon_a_level1 = 409000,
		p1_a1dun_random_level_goblin = 409093,
		a4dun_corruptspire_sidedungeon_a_level2 = 409374,
		a4dun_garden_of_hope_random_a = 409510,
		a4dun_garden_of_hope_random_b = 409511,
		px_lr_tileset_exterior_oasisdrlg = 409626,
		px_lr_tileset_exterior_oasisdrlg_small = 409777,
		px_lr_tileset_exterior_oasisdrlg_large = 409779,
		px_lr_tileset_exterior_leoricsjail = 409802,
		px_lr_tileset_exterior_leoricsjail_small = 409803,
		px_lr_tileset_exterior_leoricsjail_large = 409804,
		px_lr_tileset_exterior_tristramfieldsdrlg = 414834,
		px_lr_tileset_exterior_tristramfieldsdrlg_small = 414848,
		px_lr_tileset_exterior_tristramfieldsdrlg_large = 414849,
		px_lr_tileset_exterior_festeringwoodsdrlg_large = 414971,
		px_lr_tileset_exterior_desert = 415309,
		px_lr_tileset_exterior_desert_large = 415310,
		px_lr_tileset_exterior_desert_small = 415311,
		px_lr_tileset_exterior_festeringwoodsdrlg = 415352,
		px_lr_tileset_exterior_festeringwoodsdrlg_small = 415354,
		x1_p4_forest_coast_cellar_01 = 424373,
		x1_p4_forest_coast_cellar_02 = 424521,
		x1_p4_forest_coast_cellar_03 = 424525,
		x1_p4_forest_coast_cellar_04 = 424528,
		a3dun_ruins_frost_city_a_01 = 428493,
		x1_lr_tileset_monster_prototypes = 429679,
		a3dun_ruins_frost_city_a_02 = 430335,
		x1_p4_forest_coast_cave_level02 = 432436,
		x1_p4_forest_coast_cave_level01 = 432535,
		px_lr_tileset_exterior_battlefieldsdrlg = 432563,
		px_lr_tileset_exterior_battlefieldsdrlg_large = 432689,
		px_lr_tileset_exterior_battlefieldsdrlg_small = 432696,
		x1_westm_cesspools_randoma_level01 = 432697,
		x1_westm_cesspools_randoma_level02 = 432698,
		a2dun_aqd_special_a_level01 = 432993,
		a2dun_aqd_special_b_level01 = 432997,
		a2dun_aqd_special_a_level02 = 432998,
		a2dun_aqd_special_b_level02 = 433001,
		x1_p4_forest_ancient_city_crypt_03b = 433755,
		p2_totallynotacowlevel = 434649,
		a3dun_event_ruins_frost_kkg_dungeon = 436291,
		p4_ruins_frost_events = 436306,
		p4_lr_tileset_ruins_frost = 436403,
		p3_benchmark_challenge = 436494,
		x1_p4_forest_coast_tower_mid_lvl = 441322,
		x1_p4_forest_coast_tower_top = 441386,
		x1_p4_forest_coast_tower_mid_lvl_b = 441412,
		x1_p4_forest_coast_tower_top_winter = 442666,
		p4_lr_tileset_ruins_frost_small = 442934,
		p4_lr_tileset_ruins_frost_large = 442938,
		p4_lr_tileset_exterior_forest = 442959,
		x1_p4_leoric_estate = 443346,
		p4_lr_tileset_exterior_forest_large = 443550,
		p4_lr_tileset_exterior_forest_small = 443551,
		p4_bounty_grounds_keep = 443678,
		p4_bounty_grounds_swr = 443686,
		p4_bounty_grounds_zolt = 443705,
		p4_bounty_grounds_crypt = 443720,
		p4_bounty_grounds_leorics_garden = 443756,
		p4_setdung_wiz_opus = 443772,
		p4_bounty_grounds_neph = 443801,
		p4_lr_tileset_exterior_forest_snow = 443834,
		p4_lr_tileset_exterior_forest_snow_small = 443894,
		p4_lr_tileset_exterior_forest_snow_large = 443895,
		p4_lr_tileset_forest_coast_cave = 443996,
		p4_lr_tileset_forest_coast_cave_large = 443999,
		p4_lr_tileset_forest_coast_cave_small = 444000,
		p4_forest_snow_01 = 444305,
		p4_setdung_wiz_firebird = 444482,
		p4_setdung_wiz_rasha = 444485,
		p4_setdung_cru_akkhan = 444616,
		p4_setdung_cru_roland = 444704,
		p4_setdung_barb_kings = 444755,
		p4_setdung_barb_wastes = 444818,
		p4_setdung_barb_raekor = 444860,
		p4_setdung_barb_might = 444908,
		p4_setdung_wiz_vyr = 444953,
		p4_setdung_dh_mar = 444977,
		p4_setdung_dh_nat = 444999,
		p4_setdung_dh_ess = 445019,
		p4_setdung_dh_shadow = 445038,
		p4_setdung_wd_tooth = 445065,
		p4_setdung_wd_haunt = 445084,
		p4_setdung_wd_spider = 445108,
		p4_setdung_wd_jade = 445141,
		p4_setdung_monk_innas = 445160,
		p4_setdung_monk_sunwuko = 445177,
		p4_setdung_monk_uliana = 445194,
		p4_setdung_monk_storms = 445211,
		p4_setdung_cru_thorns = 445235,
		p4_setdung_cru_seeker = 445259,
		p4_forest_snow_icecave_01 = 445736,
		p4_forest_snow_cellar_a = 445896,
		p4_a5_bounty_grounds_zolt = 448366,
		p4_a5_bounty_grounds_swr = 448373,
		p4_a5_bounty_grounds_neph = 448381,
		p4_a5_bounty_grounds_leorics_garden = 448396,
		p4_a5_bounty_grounds_keep = 448402,
		p4_a5_bounty_grounds_crypt = 448409,
		p43_ad_cathedral_level_01 = 452721,
		p43_ad_cathedral_level_02 = 452922,
		p43_ad_cathedral_level_03 = 452984,
		p43_ad_cathedral_level_04 = 452985,
		p43_ad_catacombs_level_05 = 452991,
		p43_ad_catacombs_level_06 = 452996,
		p43_ad_catacombs_level_07 = 452997,
		p43_ad_catacombs_level_08 = 452998,
		p43_ad_caves_level_09 = 452999,
		p43_ad_caves_level_12 = 453002,
		p43_ad_caves_level_11 = 453003,
		p43_ad_caves_level_10 = 453004,
		p43_ad_hell_level_13 = 453008,
		p43_ad_hell_level_14 = 453014,
		p43_ad_hell_level_15 = 453015,
		p43_ad_hell_level_16 = 453016,
		p43_lr_tileset_interiorgrift_forest_snow = 453210,
		p43_lr_tileset_interiorgrift_desert = 453211,
		p43_lr_tileset_interiorgrift_pandext = 453212,
		p43_lr_tileset_interiorgrift_festeringwoodsdrlg = 453213,
		p43_lr_tileset_interiorgrift_forest_coast = 453214,
		p43_ad_level02_sidedungeon_darkpassage = 453440,
		p43_ad_level03_sidedungeon_leoricstomb = 453446,
		p43_ad_level06_sidedungeon_chamberofbone = 453582,
		p43_ad_level15_sidedungeon_unholyaltar = 454208,
		p43_ad_oldtristram = 455282,
		lost_souls_prototype_v2 = 456029,
		p6_church_level_01 = 456634,
		lost_souls_prototype_v3 = 457461,
		p43_ad_abandonedfarmstead = 458255,
		px_lr_tileset_exterior_moors_small = 458829,
		lost_souls_prototype_v4 = 458965,
		weekly_challenge_hub = 459976,
		p6_moor_01 = 460372,
		lost_souls_prototype_v5 = 460587,
		px_lr_tileset_church_small = 462861,
		px_lr_tileset_church = 462957,
		px_lr_tileset_exterior_moors = 462958,
		p6_church_level_02 = 464096,
		p6_cave_moors_to_church_01 = 464829,
		p6_lr_tileset_interiorgrift_moors = 465376,
		p6_moors_cave_well_01 = 465884,
		p6_setdung_necro_blood = 468085,
		p6_setdung_necro_bone = 468086,
		p6_setdung_necro_saint = 468094,
		p6_setdung_necro_plague = 468095,
		p6_church_level_02_boss = 470238,
		mb313_pand = 478413,
		mb313_church = 478433,
		mb313_moors = 478434,
		mb313_cave = 478435,
		mb313_firerealm = 478437,
		mb313_cage = 478438,
		mb313_town = 478439,
		p1_tgoblin_realm_ancient = 483057,
		p1_tgoblin_realm_bossroom_ancient = 483086,
		p73_swarmrift_bounty_grounds_caout = 486820,
		p73_swarmrift_a5_bounty_grounds_neph = 486821,
		p73_swarmrift_a5_bounty_grounds_leorics_garden = 486822,
		p73_swarmrift_a4dun_heaven_1000_monsters_fight = 486823,
		p73_swarmrift_trialrift_tileset = 486828,
		p43_lr_tileset_interiorgrift_desert_gg = 486855,
		p43_lr_tileset_interiorgrift_festeringwoodsdrlg_gg = 486856,
		p43_lr_tileset_interiorgrift_pandext_gg = 486857,
		p6_lr_tileset_interiorgrift_moors_gg = 486858,
		px_lr_tileset_exterior_tristramfieldsdrlg_small_gg = 486859,
		x1_lr_tileset_exterior_boneyards_gg = 486860,
		x1_lr_tileset_exterior_graveyard_small_gg = 486861,
		px_lr_tileset_exterior_tristramfieldsdrlg_small_gr = 487126,
		x1_lr_tileset_exterior_graveyard_small_gr = 487223,
	}

	static class WorldSnoExtensions
	{
		// all `x1_lr_tileset` worlds
		private static readonly WorldSno[] dungeonWorlds = new WorldSno[]
		{
			WorldSno.x1_lr_tileset_cath,
			WorldSno.x1_lr_tileset_corruptspire,
			WorldSno.x1_lr_tileset_leorics,
			WorldSno.x1_lr_tileset_rootcave,
			WorldSno.x1_lr_tileset_wormcaves,
			WorldSno.x1_lr_tileset_zoltarchives,
			WorldSno.x1_lr_tileset_crypt,
			WorldSno.x1_lr_tileset_floodedcave,
			WorldSno.x1_lr_tileset_icecave,
			WorldSno.x1_lr_tileset_zoltruins,
			WorldSno.x1_lr_tileset_sewers,
			WorldSno.x1_lr_tileset_keep_war,
			WorldSno.x1_lr_tileset_keep_forge,
			WorldSno.x1_lr_tileset_keep_river,
			WorldSno.x1_lr_tileset_aqueducts,
			WorldSno.x1_lr_tileset_spidercaves,
			WorldSno.x1_lr_tileset_crater,
			WorldSno.x1_lr_tileset_cath_large,
			WorldSno.x1_lr_tileset_cath_small,
			WorldSno.x1_lr_tileset_leorics_small,
			WorldSno.x1_lr_tileset_crypt_small,
			WorldSno.x1_lr_tileset_zoltarchives_small,
			WorldSno.x1_lr_tileset_cath_extralarge,
			WorldSno.x1_lr_tileset_exterior_tristramfields,
			WorldSno.x1_lr_tileset_westmarch,
			WorldSno.x1_lr_tileset_abattoir,
			WorldSno.x1_lr_tileset_bogcave,
			WorldSno.x1_lr_tileset_fortress,
			WorldSno.x1_lr_tileset_catacombs,
			WorldSno.x1_lr_tileset_hexmaze,
			WorldSno.x1_lr_tileset_exterior_bog,
			WorldSno.x1_lr_tileset_aqueducts_small,
			WorldSno.x1_lr_tileset_aqueducts_large,
			WorldSno.x1_lr_tileset_corruptspire_large,
			WorldSno.x1_lr_tileset_crypt_large,
			WorldSno.x1_lr_tileset_crater_small,
			WorldSno.x1_lr_tileset_floodedcave_large,
			WorldSno.x1_lr_tileset_icecave_large,
			WorldSno.x1_lr_tileset_keep_forge_large,
			WorldSno.x1_lr_tileset_keep_river_large,
			WorldSno.x1_lr_tileset_keep_war_large,
			WorldSno.x1_lr_tileset_leorics_large,
			WorldSno.x1_lr_tileset_rootcave_large,
			WorldSno.x1_lr_tileset_sewers_large,
			WorldSno.x1_lr_tileset_spidercaves_large,
			WorldSno.x1_lr_tileset_wormcaves_large,
			WorldSno.x1_lr_tileset_zoltarchives_large,
			WorldSno.x1_lr_tileset_zoltruins_large,
			WorldSno.x1_lr_tileset_corruptspire_small,
			WorldSno.x1_lr_tileset_floodedcave_small,
			WorldSno.x1_lr_tileset_icecave_small,
			WorldSno.x1_lr_tileset_keep_forge_small,
			WorldSno.x1_lr_tileset_keep_river_small,
			WorldSno.x1_lr_tileset_keep_war_small,
			WorldSno.x1_lr_tileset_rootcave_small,
			WorldSno.x1_lr_tileset_sewers_small,
			WorldSno.x1_lr_tileset_spidercaves_small,
			WorldSno.x1_lr_tileset_wormcaves_small,
			WorldSno.x1_lr_tileset_zoltruins_small,
			WorldSno.x1_lr_tileset_pony,
			WorldSno.x1_lr_tileset_pony_large,
			WorldSno.x1_lr_tileset_pony_small,
			WorldSno.x1_lr_tileset_exterior_wilderness,
			WorldSno.x1_lr_tileset_exterior_highlands,
			WorldSno.x1_lr_tileset_exterior_gardensofhope1,
			WorldSno.x1_lr_tileset_exterior_gardensofhope2,
			WorldSno.x1_lr_tileset_exterior_gardensofhope3,
			WorldSno.x1_lr_tileset_exterior_graveyard,
			WorldSno.x1_lr_tileset_exterior_pandext,
			WorldSno.x1_lr_tileset_breakup_wortham,
			WorldSno.x1_lr_tileset_exterior_boneyards,
			WorldSno.x1_lr_tileset_cratertowers1_small,
			WorldSno.x1_lr_tileset_cratertowers2_small,
			WorldSno.x1_lr_tileset_cratertowers3_small,
			WorldSno.x1_lr_tileset_cratertowers4_small,
			WorldSno.x1_lr_tileset_cratertowers5_small,
			WorldSno.x1_lr_tileset_cratertowers6_small,
			WorldSno.x1_lr_tileset_cratertowers7_small,
			WorldSno.x1_lr_tileset_exterior_ramparts1,
			WorldSno.x1_lr_tileset_exterior_ramparts2,
			WorldSno.x1_lr_tileset_exterior_ramparts3,
			WorldSno.x1_lr_tileset_exterior_rampartsdamaged1,
			WorldSno.x1_lr_tileset_exterior_rampartsdamaged2,
			WorldSno.x1_lr_tileset_exterior_rampartsdamaged3,
			WorldSno.x1_lr_tileset_hexmaze_large,
			WorldSno.x1_lr_tileset_hexmaze_small,
			WorldSno.x1_lr_tileset_catacombs_large,
			WorldSno.x1_lr_tileset_catacombs_small,
			WorldSno.x1_lr_tileset_bogcave_large,
			WorldSno.x1_lr_tileset_bogcave_small,
			WorldSno.x1_lr_tileset_fortress_small,
			WorldSno.x1_lr_tileset_fortress_large,
			WorldSno.x1_lr_tileset_abattoir_large,
			WorldSno.x1_lr_tileset_abattoir_small,
			WorldSno.x1_lr_tileset_westmarch_small,
			WorldSno.x1_lr_tileset_westmarch_large,
			WorldSno.x1_lr_tileset_westmarchfire,
			WorldSno.x1_lr_tileset_westmarchfire_small,
			WorldSno.x1_lr_tileset_westmarchfire_large,
			WorldSno.x1_lr_tileset_fortressislands,
			WorldSno.x1_lr_tileset_fortressislands_small,
			WorldSno.x1_lr_tileset_hellportala_small,
			WorldSno.x1_lr_tileset_hellportalb_small,
			WorldSno.x1_lr_tileset_exterior_graveyard_small,
			WorldSno.x1_lr_tileset_exterior_bog_small,
			WorldSno.x1_lr_tileset_exterior_pandext_small,
			WorldSno.x1_lr_tileset_exterior_pandext_large,
			WorldSno.x1_lr_tileset_exterior_graveyard_large,
			WorldSno.x1_lr_tileset_exterior_bog_large,
			WorldSno.x1_lr_tileset_exterior_boneyards_large,
			WorldSno.x1_lr_tileset_event_crypt_udderchaos,
			WorldSno.x1_lr_tileset_crypt_small_udderchaos,
			WorldSno.x1_lr_tileset_monster_prototypes,
			WorldSno.x1_lr_tileset_exterior_boneyards_gg,
			WorldSno.x1_lr_tileset_exterior_graveyard_small_gg,
			WorldSno.x1_lr_tileset_exterior_graveyard_small_gr,
		};


		// `x1_lr` worlds `dungeonWorlds`
		private static readonly WorldSno[] generatedNotDungeonsWorlds = new WorldSno[]
		{
			WorldSno.x1_lr_hubworld,
			WorldSno.x1_lr_level_01,
			WorldSno.x1_lr_level_02,
			WorldSno.x1_lr_level_03,
			WorldSno.x1_lr_level_04,
			WorldSno.x1_lr_level_05,
			WorldSno.x1_lr_level_06,
			WorldSno.x1_lr_level_07,
			WorldSno.x1_lr_level_08,
			WorldSno.x1_lr_level_09,
			WorldSno.x1_lr_level_10,
		};

		// `zolt` worlds
		private static readonly WorldSno[] zoltWorlds = new WorldSno[]
		{
			WorldSno.a2c2dun_zolt_treasurehunter,
			WorldSno.a2dun_zolt_sw_random01,
			WorldSno.a2dun_zolt_timed01_level01,
			WorldSno.a2dun_zolt_level01,
			WorldSno.a2dun_zolt_level02,
			WorldSno.a2dun_zolt_level03,
			WorldSno.a2dun_zolt_lobby,
			WorldSno.a2dun_zolt_bossfight_level04,
			WorldSno.a2dun_zolt_head_random01,
			WorldSno.a2dun_zolt_shadowrealm_level01,
			WorldSno.a2dun_zolt_blood02,
			WorldSno.a2dun_zolt_timed01_level02,
			WorldSno.a2dun_zolt_random_portalroulette_02,
			WorldSno.a2dun_zolt_sw_random01_level02,
			WorldSno.x1_lr_tileset_zoltarchives,
			WorldSno.x1_lr_tileset_zoltruins,
			WorldSno.x1_lr_tileset_zoltarchives_small,
			WorldSno.x1_lr_tileset_zoltarchives_large,
			WorldSno.x1_lr_tileset_zoltruins_large,
			WorldSno.x1_lr_tileset_zoltruins_small,
			WorldSno.p4_bounty_grounds_zolt,
			WorldSno.p4_a5_bounty_grounds_zolt,
			WorldSno.pvp_zolt_ruins_arena,
			WorldSno.pvp_zolt_small_arena,
		};

		// `uber` worlds
		private static readonly WorldSno[] uberWorlds = new WorldSno[]
		{
			WorldSno.uber_bossworld1,
			WorldSno.uber_bossworld2,
			WorldSno.uber_bossworld3,
			WorldSno.uber_portalworld,
			WorldSno.a4dun_uber_diablo_shadowrealm_01,
		};

		// excluded from generation worlds
		private static readonly WorldSno[] notDynamicWorlds = new WorldSno[] {
			WorldSno.a1trdun_cave_old_ruins_random01,
			WorldSno.a1trdun_cave_qa_well,
			WorldSno.a1trdun_level05_templar,
			WorldSno.a2dun_zolt_head_random01,
			WorldSno.a2c1dun_swr_caldeum_01,
			WorldSno.a2dun_cave_bloodvial_02,
			WorldSno.a3dun_ruins_frost_city_a_02,
			WorldSno.a3dun_crater_level_01,
			WorldSno.a3dun_crater_level_02,
			WorldSno.a3dun_crater_st_level01b,
			WorldSno.a3dun_crater_st_level02b,
			WorldSno.a3dun_crater_st_level04,
			WorldSno.a3dun_crater_st_level04b,
			WorldSno.a3dun_ruins_frost_city_a_01,
			WorldSno.a4dun_hell_portal_01,
			WorldSno.a4dun_hell_portal_02,
			WorldSno.a4dun_garden_of_hope_random,
			WorldSno.p4_forest_snow_icecave_01,
			WorldSno.p4_forest_snow_01,
			WorldSno.a3dun_crater_st_level01,
			WorldSno.a3dun_crater_st_level02,
			WorldSno.trdun_leoric_level02,
			WorldSno.trdun_leoric_level03,
			// all `Crater` worlds
			WorldSno.a3dun_crater_st_level01,
			WorldSno.a3dun_crater_st_level02,
			WorldSno.a3dun_crater_level_01,
			WorldSno.a3dun_crater_level_02,
			WorldSno.a3dun_crater_st_level04,
			WorldSno.a3dun_crater_level_03,
			WorldSno.a3dun_crater_st_level01b,
			WorldSno.a3dun_crater_st_level04b,
			WorldSno.a3dun_crater_st_level02b,
			WorldSno.pvp_craterst_arena,
			WorldSno.x1_lr_tileset_crater,
			WorldSno.x1_lr_tileset_crater_small,
			WorldSno.x1_lr_tileset_cratertowers1_small,
			WorldSno.x1_lr_tileset_cratertowers2_small,
			WorldSno.x1_lr_tileset_cratertowers3_small,
			WorldSno.x1_lr_tileset_cratertowers4_small,
			WorldSno.x1_lr_tileset_cratertowers5_small,
			WorldSno.x1_lr_tileset_cratertowers6_small,
			WorldSno.x1_lr_tileset_cratertowers7_small,
			// all `Hell_Portal` worlds
			WorldSno.a4dun_hell_portal_01,
			WorldSno.a4dun_hell_portal_02,
		};

		public static bool IsDungeon(this WorldSno worldSno)
        {
			return dungeonWorlds.Contains(worldSno);
        }

		public static bool IsGenerated(this WorldSno worldSno)
        {
			return worldSno.IsDungeon() || generatedNotDungeonsWorlds.Contains(worldSno);
        }

		public static bool IsUberWorld(this WorldSno worldSno)
        {
			return uberWorlds.Contains(worldSno);
        }

		public static bool IsUsingZoltCustomGrid(this WorldSno worldSno)
        {
			return zoltWorlds.Contains(worldSno);
        }

		public static bool IsNotDynamicWorld(this WorldSno worldSno)
        {
			return notDynamicWorlds.Contains(worldSno);
        }
	}
}