<?php $string = "MIDDLE EAST Escalating Syria Attack, Russia Fires Missiles From Warships
By ANNE BARNARD and ANDREW E. KRAMEROCT. 7, 2015
Photo

A site in the Syrian town of Babila that were reportedly hit by Russian airstrikes on Wednesday. 
Credit
Khalil Ashawi/Reuters


BEIRUT, Lebanon ” Backed by Russian warplanes and ground-to-ground missiles, the Syrian army began a ground offensive Wednesday against rebel forces in northern Hama province, while the Kremlin said it had fired 26 cruise missiles on Syrian targets from naval vessels in the Caspian Sea.
Although in its early stages, the coordinated assault reveals the outline of a new alliance between Syria and its main allies ” Hezbollah, Iran and Russia ” said an official with that alliance, speaking on the condition of anonymity because the parties had not detailed the coordination of military strategy.
The offensive aims to retake areas gained in the spring by an insurgent coalition, the Army of Conquest, that threated the government-held coastal province of Latakia. That province is a crucial territory for the Syrian government, the official said, adding that it was the first time since those setbacks in the spring that the governments forces had moved from defense to offense.
It was clear the missile strike from warships, from a distance of more than 900 miles, was coordinated with the ground offensive, which was reported by antigovernment activists and insurgents around Hama, and by a television station operated by Hezbollah.
Russian officials routinely describe its attacks as aimed at the Islamic State, or ISIS. However, there were no reports of large explosions in ISIS-held parts of Syria farther east ” making it less likely that the cruise missiles went there instead.
The news of the missile attack came via a televised meeting between the Russian defense minister, Sergey K. Shoigu and the President Vladimir V. Putin.
That we fired from the territory of the Caspian Sea, at a range greater than 1,500 kilometers, and hit targets precisely, this shows high qualifications, Mr. Putin said, referring to naval crew members. Mr. Shoigu said that no civilians had been injured in the attack.
The ground operation will eventually include new contingents of fighters from Hezbollah, a Shiite militia, as well as the current configuration of Syrian forces backed by Russians in the air, according to the official with the alliance. In addition, Iranian military advisers have long been active on the ground in Syria and would most likely be involved in such a crucial operation.
Speaking in tones of new confidence and optimism, the official called the Russian intervention a game-changing development that put to rest any doubts about Russias commitment to Syrias president, Bashar al-Assad, who has managed to cling to power despite a civil war that is now in its fifth year.
The ground offensive aims to push insurgents out first in northern Hama Province, where the attacks on Wednesday took place, later moving north into Idlib Province, according to the official and to diplomats and analysts in the region. Probable targets include Jabal al-Zawiya, a mountainous area that insurgents have held for years, and Jisr al-Shughour, a city in Idlib Province, which was captured by insurgents in March ” a military victory that was considered an ominous sign for the Syrian government.
The Army of Conquest is an Islamist faction that includes the Nusra Front, Al Qaedas Syrian affiliate, as well as more secular groups that often fight alongside it, including some that have received American aid. Russia has so far refused to make a distinction between the Army of Conquest and the Islamic State, labeling both groups as terrorists.
Russian diplomats, a senior foreign ministry official said, have asked the United States to identify armed groups other than units of the Syrian Army that are fighting the Islamic State and that should be avoided in airstrikes, but the official said the Russians had not yet received an answer.
If there are some forces that also have weapons in their hands and are on the ground fighting, as the coalition says, with the Islamic State, and they should not be touched, then wonderful, the official said. Give the list, give the call signs of these people. Tell us where are they located, explain why they shouldnt be touched. Indeed, this information is not provided.
Defense Secretary Ashton B. Carter, when asked about the new Syrian ground offensive in coordination with Russian airstrikes, lamented the Assad regimes use of violence against its own people.
Mr. Carter added that to the extent that Russia enables that, thats the fundamental reason we believe Russia is making a mistake in their actions in Syria.
He took issue with what he said were suggestions in the news media that the United States was cooperating with Russia on Syria, He said that the only exchanges that the Pentagon and the Russian military could have on Syria at the moment were technical discussions on how to steer clear of each others way in the skies above the country ” called deconfliction talks.
What we will do is continue basic technical discussions on safety procedures for our pilots over Syria, Mr. Carter said, while appearing at a news conference in Rome with Roberta Pinotti, the defense minister of Italy. Thats it.
NATO has repeatedly warned Russia ” so far, to little effect ” that its military intervention will only worsen the situation on the ground. NATO Officials did not have an immediate response to the cruise missile deployment on Wednesday, but pointed to earlier remarks by its secretary general, Jens Stoltenberg.
I can confirm that we have seen a substantial buildup of Russian forces in Syria, Mr. Stoltenberg said at a news conference on Monday. Air forces, air defenses, but also then ground troops in connection with the air base they have.
He continued, We also see increased naval presence of Russian ships, naval capabilities outside Syria or the eastern part of the Mediterranean.";
?>
<!DOCTYPE html>
<html>

<head>
  <meta charset="UTF-8">
  <title>cs refactored to js</title>
  <link href="css/design.css" type="text/css" rel="stylesheet">
  <script language="javascript" type="text/javascript" src="js/script.js"></script>
</head>

<body>
	<div id="wrapper">
		<section id="a01">
			<div class="label">
				01a
			</div>
			<div class="input">
			  <h2>Input</h2>
			  <label for="inNum">Value:</label>
			  <input id="inNum" type="number" placeholder="eg. 12"><br>
			  <label for="oBase">Origin base:</label>
			  <input id="oBase" type="number" placeholder="eg. 10"><br>
			  <label for="tBase">Target base:</label>
			  <input id="tBase" type="number" placeholder="eg. 2">
			</div>
			<hr>
			<div class="output">
				<h2>Output</h2>
				<label for="outNum">Target Value:</label>
				<input id="outNum" type="text">
			</div>
			<button onclick="convertFromToBase()">action</button>
		</section>
		<section id="b01">
			<div class="label">
				01b
			</div>
			<div class="input">
			<h2>Input</h2>
			  <label for="inCode">Encoded Text:</label>
			  <input id="inCode" type="text" placeholder="eg. 111010101001" value="010000101101101100111010010001000110101">
			</div>
			<hr>
			<div class="output">
				<h2>Output</h2>
				<label for="outString">Decoded Text:</label>
				<input id="outString" type="text">
			</div>
			<button onclick="decode()">action</button>
		</section>
		<section id="c01">
			<div class="label">
				01c
			</div>
			<div class="input">
				<h2>Input</h2>
				<textarea id="text"><?php echo $string; ?></textarea>
			</div>
			<hr>
			<div class="output">
				<h2>Output</h2>
				<textarea id="textOut">
				</textarea>
			</div>
			<button onclick="analyze()">action</button>
		</section>
	</div>
</body>
</html>