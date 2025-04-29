# Inclusive Avatar Design Guidelines
Kexin Zhang<sup>1</sup>, Edward Scott Spencer Jr.<sup>2</sup>, Abijith Manikandan<sup>2</sup>, Andric Li<sup>1</sup>, Ang Li<sup>1</sup>, Yaxing Yao<sup>2</sup>, Yuhang Zhao<sup>1</sup>

<sup>1</sup>University of Wisconsin-Madison, <sup>2</sup>Virginia Tech

## G0. Support disability representation in social VR avatars.
Approximately 1.3 billion people experience significant disability, representing about 16% of the global population. It’s important to ensure people with disabilities are included and represented equally in emerging technology such as social VR. As long as the platform involves avatar-based interactions, there is design space to support disability representation. The following set of guidelines can be flexibly applied to a variety of social VR platforms with different (1) avatar types (e.g., humanoid avatars in Rec Room [ 64] vs. robotic-type avatars in Among Us), (2) aesthetic styles (e.g., life-like avatars in Horizon Worlds vs. abstract avatars in Roblox)), and (3) content focus (e.g., communication-heavy type in VRChat vs. game-centric in Rec Room). We encourage practitioners to adopt G0 as a fundamental mindset when developing and designing avatars, considering it in the early stages, and consistently exploring opportunities to support disability representation.


## G1.  Avatar Body Appearance
### G1.1. Default to a full-body avatar to enable the representation of a broad range of disabilities across different body parts (Highly Recomended-HR).

Avatar interfaces should offer full-body avatar options. About 296,000 people in the U.S. live with paralysis of the lower half of the body, with around 17,900 new cases each year. Given the large affected user size and dominant preferences for full-body avatars over others (e.g., upper-body only, or head and hands only), we recommend making it the default or the starting avatar template, giving users the maximum flexibility to further customize their avatars as they prefer.

*“People can only get my whole disability identity with the full body.”*
<p align="right">– a person with cerebral palsy</p>

*“I prefer a full-body avatar, because [it shows] how [people with disabilities] navigate the pathway, how they move the hands and the fingers, and how they read braille. Everything can be oriented to the people.”*
<p align="right">– a person with visual impairment</p>

<ins>Example:</ins>
A full-body avatar with a prosthetic left foreleg.

<img src="https://github.com/MadisonAbilityLab/Inclusive-Avatar-Guidelines-and-Library/blob/main/guidelines_image/G1.2.png" alt="G1.2. Example" width="220">


### G1.2. Enable flexible customization of body parts as opposed to using non-adjustable avatar templates (HR).

Avatar interfaces should provide people with disabilities sufficient flexibility to customize each avatar body part. While the customization spans a wide range, the most commonly mentioned body parts to customize include (1) avatar height, (2) body shape, (3) limbs (i.e., number of limbs, length and strength of each limb), and (4) facial features (e.g., mouth shape, eye size). Asymmetrical design options of body parts (e.g., eyes, ears) should also be available, such as changing size and direction of each eyeball to reflect disabilities like strabismus.

*“I have a limb difference, [and I am] a left forearm amputation. So I would really like to see characters where maybe they don't have two long arms, but they have one long standard arm and one shorter [arm], like to the elbow. Or even if they do have two long arms, but one of them doesn't have a hand, or just one round-off around the wrist [...] instead of extending completely with a five-fingered hand.”*
<p align="right">– an amputee</p>

*“I have one eye that's in a completely different shape than the other. So I think being able to customize your eyes to two different shapes should reflect what is actually going on on your face. Now you can only pick one set.”*
<p align="right">– a person with visual and mobility impairments</p>

<ins>Example:</ins>
Options that can customize the size of each eye.

<img src="https://github.com/MadisonAbilityLab/Inclusive-Avatar-Guidelines-and-Library/blob/main/guidelines_image/G1.3.gif" alt="G1.3. Example" width="220">


### G1.3. Prioritize human avatars to emphasize the “humanity” rather than the “disability” aspect of identity (HR). 

People with disabilities often face misconceptions that they are either ‘superheroes’ or ‘tragic’, which reduce individuals to their disability label rather than seeing them as whole persons. To avoid such misconceptions, avatars should have human-like models to represent disability as an integral part of personal identities, which often intersect with other identities such as race and gender. People with disabilities also reported feeling more connected to humanoid avatars when representing personal identities in social VR.

*“Humanoid avatars show me as a whole person. I identify as a black woman with a disability, and that's really important when discussing a personal identity, because when describing somebody, you wouldn't just say, ‘Oh, they have a disability,’ instead you would say, ‘Oh, they're non-binary or female, and they're African American or Caucasian, and they have a disability.’ They all go together.”* 
<p align="right">– a person with cerebral palsy</p>

<ins>Example:</ins>
VALID validated avatar library (left)[^2] and Ready Player Me avatar (right)[^3] present human avatars that can show intersecting identities of disabilities, race, and gender. 

<img src="https://github.com/MadisonAbilityLab/Inclusive-Avatar-Guidelines-and-Library/blob/main/guidelines_image/G1.4.png" alt="G1.4. Example" width="290" height="150">

[^2]: VALID validated avatar library. https://research.google/blog/valid-a-perceptually-validated-virtual-avatar-library-for-inclusion-and-diversity/ 

[^3]: Ready Player Me avatar. https://readyplayer.me/ 


### G1.4. Provide non-human avatar options to free users from social stigma in real life (Recommended-R). 

People with disabilities often face judgment based on their physical differences in real life. Avatars with non-human forms, such as robots and animals, can potentially lower others’ expectations of “typical” appearance and behaviors, freeing people with disabilities from societal judgements and stigma often associated with disabilities. 

*"I think [non-human avatars] hide more of my real disabilities, like being the opposite of showing off my disabilities."* 
<p align="right">– a person with cerebral palsy</p>

*"It feels like people's expectations of how neurotypical I'm gonna seem are lowered if I'm a robot or just a non-human avatar."*
<p align="right">– a person with mental health conditions</p>

<ins>Example:</ins>
A robotic avatar representing left forearm amputation[^4].

<img src="https://github.com/MadisonAbilityLab/Inclusive-Avatar-Guidelines-and-Library/blob/main/guidelines_image/G1.5.png" alt="G1.5. Example" width="220">

[^4]: Behance. https://www.behance.net/gallery/81759323/Low-Poly-Destructible-Robot


## G2. Avatar Body Dynamics: Facial Expression, Posture, and Body Motion
### G2.1. Allow simulation or tracking of disability-related behaviors but only based on user preference (HR).

Representing the realistic movements of people with disabilities on avatars could make them feel more connected with their avatars and immersed in the VR experience. For instance, a person with Tourette’s Syndrome may have tics on their face and prefer showing them authentically via their avatar design. However, the realistic simulation of disability-related behaviors on avatars may also reinforce the stereotype people with disabilities experience in real life. For example, for people who experience unconventional or involuntary movements (e.g., stumbling, nervous tics), directly simulating these movements can be disrespectful and should be avoided. Developers should be careful not to create simulations that may cause misunderstanding or reinforce stereotypes, and should only do so if users prefer it. 

*“I think it would be cool if you could choose to have [the movement to be reflected]. But I also think that it is a very fine line between inclusion and offensive imitation.”* 
<p align="right">– a person with mobility disabilities</p>

*“The way I move authentically is kind of jaggy, and I swerve. People asked me if I'm drunk all the time. So you know I'd like to go as quickly as I can in a smooth way [...] even though that's not authentic."* 
<p align="right">– a person with mobility disabilities</p>

<ins>Example:</ins>
Avatar can show motor tics (left) or not (right) based on the user's preference.

<img src="https://github.com/MadisonAbilityLab/Inclusive-Avatar-Guidelines-and-Library/blob/main/guidelines_image/G2.1.png" alt="G2.1. Example" width="320" height="150">


### G2.2. Enable expressive facial animations to deliver invisible status (R).

For people with invisible disabilities, enabling expressive facial expressions is critical because their conditions (e.g., depression, bipolar disorder, and anxiety) often surface through their emotions. It’s especially important to include expressions representing both positive and negative emotions (e.g., sadness, anxiety, or even crying) to portray the user’s mental status visually and demonstrate what they are really feeling. Including the five basic emotions is a good starting point, and practitioners should expand and diversify based on their own use scenarios. This guideline is particularly helpful for communication-heavy or mental therapy platforms, where expressing a range of emotions helps people with disabilities convey their feelings more accurately.

*“Depression is part of my life, and I think avatars need to spend a little more time not looking so happy all the time, which is not an option there. [The avatars] are always smiling. I think that needs to be a little bit more [variations].”*
<p align="right">– A person with severe depression</p>

*“When representing depression, the facial expression is more sad or in thought. And then when having ADHD moments, [the avatar] being more excited or manic.”*
<p align="right">– A person with depression and ADHD</p>

<ins>Example:</ins>
Avatar shows diverse emotions, including anxiety (left), sadness (middle), and happiness (right).

<img src="https://github.com/MadisonAbilityLab/Inclusive-Avatar-Guidelines-and-Library/blob/main/guidelines_image/G2.2.png" alt="G2.2. Example" width="320" height="150">


### G2.3. Prioritize equitable capability and performance of avatar over the authentic behaviors of people with disabilities (HR).

While people with disabilities should have the option to reflect their unique movements through their avatars if they so choose (e.g., limp while walking), these movement characteristics should not impact the capabilities or performance of the avatar, thus creating a fair user experience for all. For example, the movement speed of an avatar in a wheelchair should be the same as the walking speed of other avatars. 

*“I walk with a slight limp, [but] I don't think I need the actual movement [on avatars] to reflect how [fast] I walk. [Because] when I use games, I see the movement aspect more of a practicality than part of the game [...] I think having a limp would be cool, but I wouldn't want to be slower than [other avatars]. I wouldn't want to have a maximum speed, because I chose to have a limp earlier in the avatar making process."* 
<p align="right">– a person with mobility disabilities</p>

*“Being able to just keep up with peers’ [avatars], pace-wise, would be the most important thing.”* 
<p align="right">– a person with mobility disabilities</p>

<ins>Example:</ins>
The avatar with the wheelchair moves at the same speed as the avatar without the wheelchair.

<img src="https://github.com/MadisonAbilityLab/Inclusive-Avatar-Guidelines-and-Library/blob/main/guidelines_image/G2.3.gif" alt="G2.3. Example" width="250">


## G3. Assistive Technology Design
### G3.1. Offer various types of assistive technology to cover a wide range of disabilities (HR). 

People with disabilities see their assistive technologies as an extension of their body. An avatar which features the specific assistive technology they use is important because it helps represent their identities and offers a feeling of empowerment, inclusion, and immersion. Avatar platforms should therefore offer assistive technologies that are commonly used by people with different types of disabilities. 

According to our large-scale interview data, the most desired types of assistive technologies include: (1) mobility aids (e.g., wheelchair, cane, and crutches); (2) prosthetic limbs; (3) visual aids (e.g., white cane, glasses, and guide dog); (4) hearing aids and cochlear implants; and (5) health monitoring devices (e.g., insulin pumps, ventilator, smart watches). 

Practitioners should consider including at least these five categories of assistive technologies in avatar interfaces. In addition, due to people with disabilities’ different technology preferences, we encourage practitioners to offer more than one assistive technology option within each category, for example, including guide dog, white cane, and glasses for visual aids.

*“For people in wheelchairs, our wheelchair is an extension of our body [...] we view it emotionally as an extension of ourselves, and it gives us our independence.”*
<p align="right">– a wheelchair user</p>

*“I think that the wheelchair would be a good addition to it. Being able to move it in the VR world gives me a sense that I'm a part of this VR world too.”*
<p align="right">– a wheelchair user</p>

<ins>Example:</ins>
Offer multiple types of mobility aids, such as crutches (left)[^5] and prosthetic limb (right)[^6]. 

<img src="https://github.com/MadisonAbilityLab/Inclusive-Avatar-Guidelines-and-Library/blob/main/guidelines_image/G3.1.png" alt="G3.1. Example" width="320" height="180">

### G3.2. Allow detailed customization of assistive technology for personalized disability representation (HR).

With assistive technology being an extension of the user’s body, being able to customize the design of the assistive technology is as important as customizing the avatar’s appearance. A spectrum of options should be available, rather than a simple default choice. For example, wheelchair options should include both manual and powered models. In addition, customizing the aesthetics of the assistive technology, such as adjusting the color or adding personalized decoration (e.g., stickers on wheelchairs), offers a unique way for people with disabilities to express their personalities. 

*“[Now] you either have a wheelchair or no wheelchair, but you can't customize the type, shape, or any various add-ons. Like is it motorized [wheelchair]? Is it like a manual one? So I think having the ability to choose what additional features you'd like to add would be really nice.”* 
<p align="right">– prosthetic limb user</p>

*“Making some more customizations in the wheelchair. Because again, [it’s] in the same way that you make customizations for eye color, nose shape, [and] all those things.”* 
<p align="right">– a person with mobility disabilities</p>

<ins>Example:</ins>
Users can adjust the color of the power wheelchair, like the cushions, wheels, and chassis cover.

<img src="https://github.com/MadisonAbilityLab/Inclusive-Avatar-Guidelines-and-Library/blob/main/guidelines_image/G3.2.png" alt="G3.2. Example" width="320" height="160">


### G3.3. Provide high-quality, authentic simulation of assistive technology to present disability respectfully and avoid misuse (HR).

As an emerging social platform, it’s not uncommon to see some avatars with disability features (e.g., avatars on wheelchairs). However, these avatars are usually designed in a low-quality or stereotypical manner, which leads to the misuse of assistive technology, such as trolling or memeing, perpetuating stigma toward people with disabilities. To represent disability respectfully, assistive technology should be designed and simulated authentically. It should be high in quality and contain sufficient details. For example, the design of a white cane for people with low vision should follow the standardized color selection for such walking aids. We recommend practitioners to model assistive technologies by following their established design
standards, such as design guidelines for white canes [58], wheelchairs [65], and hearing devices [26].

*“[I’ve seen] really poor representation [of wheelchairs]. They're usually joke avatars or meme avatars that have wheelchairs.”*
<p align="right">– a person with mental health conditions</p>

*“​​So while walking, the tip of the white cane should move like the pendulum motion, [moving] forth and back in that way.”* 
<p align="right">– a person who is blind and low vision</p>

<ins>Example:</ins>
The low-fidelity wheelchair (left)[^7] might be misperceived as mocking. Instead, the wheelchair should be designed with high-fidelity and realistic details (right) to represent disability respectfully.

<img src="https://github.com/MadisonAbilityLab/Inclusive-Avatar-Guidelines-and-Library/blob/main/guidelines_image/G3.3.png" alt="G3.3. Example" width="320" height="160">

[^7]: Sketchfab wheelchair model. https://sketchfab.com/3d-models/wheelchair-json-08f4dafe05304cb785d9bcf980a44bc5 


### G3.4. Demonstrate the liveliness of people with disabilities through dynamic interactions with assistive technology (R).

In addition to the visual details, showing how people with disabilities actively control and interact with the assistive technology is another way to demonstrate independence. For example, the avatar should demonstrate circular arm movement when pushing a manual wheelchair, and the wheels should roll. Additionally, the proper posture of the avatar sitting up tall in a wheelchair also reflects the liveliness and capability of the user.

*“I think having the option to roll [wheelchair] instead of walking would be good. I’ve seen some 3D models of wheelchair users in video games, and their arms don't move while they're rolling, which is really weird to me. Because I push myself with my hands.”* 
<p align="right">– a person with mobility disabilities</p>

*“You would lean forward on the joystick, and the wheels would be moving. Or if you go backwards, you’d be pulling [the joystick] back and it would move backwards.”*
<p align="right">– a person with mobility disabilities</p>

<ins>Example:</ins>
Avatar controls the manual wheelchair through pushing.

<img src="https://github.com/MadisonAbilityLab/Inclusive-Avatar-Guidelines-and-Library/blob/main/guidelines_image/G3.5.gif" alt="G3.5. Example" width="220">


### G3.5. Avoid overshadowing the avatar body with the assistive technology (HR).

When representing disability through assistive technology, the focus should always be on the avatar’s body rather than its assistive technology. In practice, the size of assistive technology should not dominate the avatar body but rather fit the body size. Developers should make sure users can easily adjust the size of assistive technology to fit the avatar's body size well.

*“The wheelchair is not the focus of the image. [But] the avatar is having a good time, and that's the focus of the image.”*
<p align="right">– a wheelchair user</p>

*“I think that having the option to actually make the chair larger or smaller, depending on how large or small your avatar is, is a good detail. Because sometimes wheelchairs don't fit you. I have encountered 3d models where the wheelchair is so big and the person sitting in it is so small, and it just doesn't look right.”*
<p align="right">– a wheelchair user</p>

<ins>Example:</ins>
Users can change the size of assistive technology to match with their avatar size.

<img src="https://github.com/MadisonAbilityLab/Inclusive-Avatar-Guidelines-and-Library/blob/main/guidelines_image/G3.6.gif" alt="G3.6. Example" width="220">



## G4. Peripherals around Avatars
### G4.1. Provide suitable icons, logos, and slogans that represent disability communities (HR). 

Including representative symbols of disability communities helps people to express their disabilities in a symbolic way. These symbols can be featured on avatar’s clothing and accessories, or elsewhere. Examples of symbols include the rainbow and infinity logo that are widely recognized within the autism community, and sunflowers to symbolize hidden disabilities. We compiled a list of widely recognized and preferred symbols that represent different disabilities for practitioners to refer to, including (1) the rainbow infinity symbol the represents the autism community, (2) the sunflower that represents hidden disabilities, (3) the disability pride flag, (4) the spoons, symbolizing spoon theory for people with chronic illness, and (5) the zebra symbols for rare diseases. 

*“Now we have like characters who can wear T-shirts with the LGBTQ plus pride flag on it, or they can wear T-shirts that have ‘Black Lives Matters.’ So having equivalent things for disability would be awesome.”*
<p align="right">– a person with mobility disabilities</p>

*“It’s about hidden disabilities, and you can get sunflower lanyards, which is a way of saying ‘I'm disabled, but you can't tell.’ So if the character looks like they're walking and they've got sparkly, flowy sunflowers behind them, [that] would be cool.”*
<p align="right">– a person with mobility disabilities</p>

<ins>Example:</ins>
An avatar wearing a T-shirt with a rainbow and infinity symbol to represent the autism spectrum disorder community. 

<img src="https://github.com/MadisonAbilityLab/Inclusive-Avatar-Guidelines-and-Library/blob/main/guidelines_image/G4.1.png" alt="G4.1. Example" width="220">


### G4.2. Leverage spaces beyond the avatar body to present disabilities (R).

The space surrounding an avatar offers opportunities for people with disabilities, especially those with invisible ones, to creatively represent themselves. For example, people with depression want to add visual indicators in the avatar's background to show their current conditions (i.e., a cloudy and rainy background to symbolize a user feeling depressed at the moment). Another example would involve using icons, such as a battery symbol above the avatar's head, which would change levels depending on the user’s mood. 

*“I’d imagine there were things around me, like a dark gray cloud or it's raining in the background and being right above you. And everywhere you go, it's right there.”* 
<p align="right">– a person with ADHD and depression</p>

*“My energy levels can fluctuate just a lot. Someday, I may have a little bit of energy, and the next day I may have a lot of energy, and that could actually change within a matter of hours. So the idea that I have is a battery symbol that I could adjust the battery level shown on that to show you how much energy that I have to spend. It's a signal to my friends that ‘hey, my battery's low, I may sound really tired right? I'm okay, I just have low energy.’ [Other times] I could turn my battery all the way up and be like, ‘Hey, let's see, we can do something a little bit more active​​.’”*
<p align="right">– a person with neurodivergence and low vision</p>

<ins>Example:</ins>
An avatar with a floating bubble overhead, showing a level of social energy.

<img src="https://github.com/MadisonAbilityLab/Inclusive-Avatar-Guidelines-and-Library/blob/main/guidelines_image/G4.2.png" alt="G4.2. Example" width="320" height="150">


## G5. Design of Avatar Customization and Control Interface
### G5.1. Distribute disability features across the entire avatar interface rather than gathering them in a specialized category (HR).

Putting all disability-related features in one category is a form of exclusion. It makes people with disabilities feel they are using features intentionally designed as “for disabilities”, which sets them apart from other users. Instead, disability-related features should be naturally embedded in all aspects of the avatar customization interface. For example, including assistive technologies like walking canes alongside other accessories like hats or glasses rather than a special ‘disability representation’ section, could mitigate this problem.  

*“Have those [disability representation] options in a variety of places, not like to create a disabled avatar, [you need to] go 13 levels down to the left, and [there’s a] submenu for that. Just make it integral to what you're designing, instead of making it like, ‘you gotta go on the short bus to get to the avatars for people with disabilities. Make it a part of everything else. Don't isolate it.”*
<p align="right">– a person who is blind</p>

*“You can include a cane with the accessories tab instead of having a disabled tab over there…that can be kind of ostracizing. Just treating them as neutral instead of either a burden to have to design or something you get to feel really special for designing.”* 
<p align="right">– a person with mental health conditions</p>

<ins>Example:</ins>
Walking canes and wheelchairs are included under the accessory category along with items like glasses, hats and bags.

<img src="https://github.com/MadisonAbilityLab/Inclusive-Avatar-Guidelines-and-Library/blob/main/guidelines_image/G5.1.png" alt="G5.1. Example" width="330" height="350">


### G5.2. Use input controls that offer precise adjustments whenever possible (HR). 

A common problem with current avatar customization interfaces is not being able to find customization options which accurately represent people’s disabilities. An example of addressing this issue would be to give users the ability to modify the exact length of a missing or impaired limb. Developers and designers should use input controls that offer a continuous range of options for people to flexibly represent themselves. For example, sliders and knobs are continuous input controls that enable fine-grained customizations. 

*“[I prefer] the sliding scale … [so] you can really change it on a very particular level.”* 
<p align="right">– a person with autism</p>

*“It's better to have a spectrum of choices, or even a slider like for people to change your nuanced level.”* 
<p align="right">– a person with mobility disabilities</p>

<ins>Example:</ins>
Offer a slider to change the length of limbs.

<img src="https://github.com/MadisonAbilityLab/Inclusive-Avatar-Guidelines-and-Library/blob/main/guidelines_image/G5.2.gif" alt="G5.2. Example" width="220">


### G5.3. Offer an easy control to turn on and off disability features (HR).

People don’t want to be defined by their disability and show their disability all the time. The disclosure of disability often depends on social contexts. For example, people might not want to disclose their disabilities when they are surrounded by strangers or unfriendly users. For this reason, social VR platforms should allow users to easily toggle on and off the disability-related features as needed. For example, implementing a shortcut that can instantly remove disability features from an avatar would address this issue. Important control functions include: (1) toggling on and off the disability-related features; (2) switching between different saved avatars; and (3) updating status for fluctuating conditions.

*“If I'm in a very comfortable setting, and [people are] accepting, I'm going to come in there [as an avatar with disability-related features]. [At the same time,] it's important to have that [avatar with disability-related features] to be changed, where I can still have how my body shows up in the world but not necessarily with the wheelchair. That’s important, because although I have a disability and I'm comfortable with it, it is not the most important thing to me. So sometimes I might not want to lead with that, especially when you have physical disabilities that people can see, where you encounter a lot in the world where you have no control over how people see you right away.”* 
<p align="right">– a person with mobility disability</p>

<ins>Example:</ins>
Users should be able to turn disability-related features on and off with a single click.

<img src="https://github.com/MadisonAbilityLab/Inclusive-Avatar-Guidelines-and-Library/blob/main/guidelines_image/G5.3.gif" alt="G5.2. Example" width="370" height="130">
